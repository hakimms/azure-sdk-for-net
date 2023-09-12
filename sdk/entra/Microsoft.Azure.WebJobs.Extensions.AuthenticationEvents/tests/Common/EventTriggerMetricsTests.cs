// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Azure.WebJobs.Extensions.AuthenticationEvents.Framework;
using Microsoft.Azure.WebJobs.Extensions.AuthenticationEvents.TokenIssuanceStart;
using NUnit.Framework;
using System.Linq;
using System.Net.Http;

namespace Microsoft.Azure.WebJobs.Extensions.AuthenticationEvents.Tests
{
    [TestFixture]
    public class EventTriggerMetricsTests
    {
        [Test]
        public void TestSetMetricHeadersNull()
        {
            AuthenticationEventRequestBase requestBase = null;
            EventTriggerMetrics.SetMetricHeaders(requestBase);
            Assert.IsNull(requestBase, "Verify AuthenticationEventRequestBase is not set to anything when null.");
        }

        [Test]
        public  void TestSetMetricHeaders()
        {
            HttpRequestMessage httpRequestMessage = new()
            {
                RequestUri = new System.Uri("https://www.helloworld.com?test=1")
            };

            AuthenticationEventRequestBase requestBase = new TokenIssuanceStartRequest(httpRequestMessage);

            EventTriggerMetrics.SetMetricHeaders(requestBase);

            var headers = requestBase.HttpRequestMessage.Headers;

            Assert.IsTrue(headers.Contains(EventTriggerMetrics.HeaderKeys.Platform));
            Assert.IsTrue(headers.Contains(EventTriggerMetrics.HeaderKeys.ProductVersion));
            Assert.IsTrue(headers.Contains(EventTriggerMetrics.HeaderKeys.Runtime));

            Assert.AreEqual("windows", headers.GetValues(EventTriggerMetrics.HeaderKeys.Platform).First(), "Verify the platform");
            Assert.AreEqual("1.0.0.4", headers.GetValues(EventTriggerMetrics.HeaderKeys.ProductVersion).First(), "Verify the version. Needs to be updated when version is updated.");
            Assert.AreEqual(".NET", headers.GetValues(EventTriggerMetrics.HeaderKeys.Runtime).First(), "Verify the runtime.");
        }

        [Test]
        public void TestSetMetricHeadersOverride()
        {
            HttpRequestMessage httpRequestMessage = new()
            {
                RequestUri = new System.Uri("https://www.helloworld.com?test=1")
            };

            AuthenticationEventRequestBase requestBase = new TokenIssuanceStartRequest(httpRequestMessage);

            EventTriggerMetrics.Platform = "linux";
            EventTriggerMetrics.ProductVersion = "10.0.0";
            EventTriggerMetrics.RunTime = "JS";

            EventTriggerMetrics.SetMetricHeaders(requestBase);

            var headers = requestBase.HttpRequestMessage.Headers;

            Assert.IsTrue(headers.Contains(EventTriggerMetrics.HeaderKeys.Platform));
            Assert.IsTrue(headers.Contains(EventTriggerMetrics.HeaderKeys.ProductVersion));
            Assert.IsTrue(headers.Contains(EventTriggerMetrics.HeaderKeys.Runtime));

            Assert.AreEqual("linux", headers.GetValues(EventTriggerMetrics.HeaderKeys.Platform).First(), "Verify the platform");
            Assert.AreEqual("10.0.0", headers.GetValues(EventTriggerMetrics.HeaderKeys.ProductVersion).First(), "Verify the version. Needs to be updated when version is updated.");
            Assert.AreEqual("JS", headers.GetValues(EventTriggerMetrics.HeaderKeys.Runtime).First(), "Verify the runtime.");
        }
    }
}
