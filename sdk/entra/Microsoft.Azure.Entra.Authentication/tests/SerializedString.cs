namespace Microsoft.Azure.Entra.Authentication.Tests
{
    public static class SerializedString
    {
        // OnTokenIssuanceStart
        public const string SerializedEventApiResponseProvideClaimsForToken = "{\"actions\":[{\"@odata.type\":\"microsoft.graph.provideClaimsForToken\",\"claims\":{\"claimKey\":\"claimValue\",\"claimKey2\":[\"claimValue1\",\"2022-09-20T22:27:40.470Z\"]}}]}";
        public const string SerializedEventApiResponseProvideClaimsForTokenWithNamespace = "{\"actions\":[{\"@odata.type\":\"microsoft.graph.tokenIssuanceStart.provideClaimsForToken\",\"claims\":{\"claimKey\":\"claimValue\",\"claimKey2\":[\"claimValue1\",\"2022-09-20T22:27:40.470Z\"]}}]}";
    }
}
