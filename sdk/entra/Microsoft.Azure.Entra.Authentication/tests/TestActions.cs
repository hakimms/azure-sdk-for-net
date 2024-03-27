using Newtonsoft.Json;

namespace Microsoft.Azure.Entra.Authentication.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProvideClaimsForToken()
        {
            ProvideClaimsForTokenAction serialized = JsonConvert.DeserializeObject<ProvideClaimsForTokenAction>(SerializedString.SerializedEventApiResponseProvideClaimsForToken);
            Assert.IsNotNull(serialized);
            Assert.IsNotNull(serialized.Claims);
        }
    }
}