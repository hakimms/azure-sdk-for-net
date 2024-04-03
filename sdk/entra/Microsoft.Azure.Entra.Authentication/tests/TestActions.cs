using Newtonsoft.Json;

namespace Microsoft.Azure.Entra.Authentication.Tests
{
    public class Tests
    {
        private JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
        {
            DateParseHandling = DateParseHandling.None
        };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProvideClaimsForToken()
        {
            OnTokenIssuanceStartCalloutResponseData? apiResponse = JsonConvert.DeserializeObject<OnTokenIssuanceStartCalloutResponseData>(SerializedString.SerializedEventApiResponseProvideClaimsForToken, jsonSerializerSettings);

            Assert.IsNotNull(apiResponse);

            ProvideClaimsForTokenAction? eventAction = apiResponse.Actions.First() as ProvideClaimsForTokenAction;

            Assert.IsNotNull(eventAction);
            Assert.IsNotNull(eventAction.Claims);
        }

        [Test]
        public void OnTokenIssuanceStartCalloutRequest()
        {
            OnTokenIssuanceStartCalloutRequest? onTokenIssuanceStartCalloutRequest = JsonConvert.DeserializeObject<OnTokenIssuanceStartCalloutRequest>(SerializedString.SerizlizedRequest_TokenIssuanceStart);

            Assert.IsNotNull(onTokenIssuanceStartCalloutRequest);
            Assert.IsNotNull(onTokenIssuanceStartCalloutRequest.Data);
            Assert.IsTrue(onTokenIssuanceStartCalloutRequest.Data is OnTokenIssuanceStartCalloutRequestData);
        }
    }
}