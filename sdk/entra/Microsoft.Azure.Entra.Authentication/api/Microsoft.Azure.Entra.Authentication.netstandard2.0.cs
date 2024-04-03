namespace Microsoft.Azure.Entra.Authentication
{
    [Newtonsoft.Json.JsonObjectAttribute(ItemNullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
    public partial class AuthenticationEventContext
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        public AuthenticationEventContext() { }
        [Newtonsoft.Json.JsonPropertyAttribute("client")]
        public Microsoft.Azure.Entra.Authentication.AuthenticationEventContextClient Client { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("clientServicePrincipal")]
        public Microsoft.Azure.Entra.Authentication.AuthenticationEventContextServicePrincipal ClientServicePrincipal { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("correlationId")]
        public string CorrelationId { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public Microsoft.Azure.Entra.Authentication.AuthenticationProtocolType? Protocol { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("resourceServicePrincipal")]
        public Microsoft.Azure.Entra.Authentication.AuthenticationEventContextServicePrincipal ResourceServicePrincipal { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public Microsoft.Azure.Entra.Authentication.AuthenticationEventContextUser User { get { throw null; } set { } }
    }
    [Newtonsoft.Json.JsonObjectAttribute(ItemNullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
    public partial class AuthenticationEventContextClient
    {
        public AuthenticationEventContextClient() { }
        [Newtonsoft.Json.JsonPropertyAttribute("ip")]
        public string ClientIP { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public string Locale { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("market")]
        public string Market { get { throw null; } set { } }
    }
    [Newtonsoft.Json.JsonObjectAttribute(ItemNullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
    public partial class AuthenticationEventContextServicePrincipal
    {
        public AuthenticationEventContextServicePrincipal() { }
        [Newtonsoft.Json.JsonPropertyAttribute("appDisplayName")]
        public string AppDisplayName { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("appId")]
        public string AppId { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public string DisplayName { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public string Id { get { throw null; } set { } }
    }
    [Newtonsoft.Json.JsonObjectAttribute(ItemNullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
    public partial class AuthenticationEventContextUser
    {
        public AuthenticationEventContextUser() { }
        [Newtonsoft.Json.JsonPropertyAttribute("companyName")]
        public string CompanyName { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("createdDateTime")]
        public System.DateTime? CreatedDateTime { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public string DisplayName { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
        public string GivenName { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public string Id { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("mail")]
        public string Mail { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("onPremisesSamAccountName")]
        public string OnPremisesSamAccountName { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("onPremisesSecurityIdentifier")]
        public string OnPremisesSecurityIdentifier { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("onPremisesUserPrincipalName")]
        public string OnPremisesUserPrincipalName { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("preferredDataLocation")]
        public string PreferredDataLocation { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("preferredLanguage")]
        public string PreferredLanguage { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("surname")]
        public string Surname { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("userPrincipalName")]
        public string UserPrincipalName { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("userType")]
        public string UserType { get { throw null; } set { } }
    }
    [Newtonsoft.Json.JsonConverterAttribute(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AuthenticationProtocolType
    {
        [System.Runtime.Serialization.EnumMemberAttribute(Value="OAUTH2.0")]
        OAUTH2 = 0,
        [System.Runtime.Serialization.EnumMemberAttribute(Value="SAML")]
        SAML = 1,
        [System.Runtime.Serialization.EnumMemberAttribute(Value="WS-FED")]
        WSFED = 2,
        UnkownFutureValue = 3,
    }
    public partial class BooleanDirectoryAttribute : Microsoft.Azure.Entra.Authentication.DirectoryAttributeTyped<bool?>
    {
        public static readonly string ODataTypeName;
        [Newtonsoft.Json.JsonConstructorAttribute]
        public BooleanDirectoryAttribute() { }
        public BooleanDirectoryAttribute(Microsoft.Azure.Entra.Authentication.DirectoryAttributeType attributeType, bool? value) { }
    }
    [Newtonsoft.Json.JsonObjectAttribute(ItemNullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
    public abstract partial class CustomExtensionCalloutRequest
    {
        protected CustomExtensionCalloutRequest() { }
        protected CustomExtensionCalloutRequest(string tenantId, string resourceAppId, Microsoft.Azure.Entra.Authentication.EventType eventType) { }
        [Newtonsoft.Json.JsonPropertyAttribute("source", Order=-2)]
        public string Source { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute("type", Order=-3)]
        public string Type { get { throw null; } }
    }
    public abstract partial class CustomExtensionCalloutRequestData : Microsoft.Azure.Entra.Authentication.CustomExtensionData
    {
        protected CustomExtensionCalloutRequestData() { }
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationContext")]
        public Microsoft.Azure.Entra.Authentication.AuthenticationEventContext AuthenticationContext { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("authenticationEventListenerId")]
        public string AuthenticationEventListenerId { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("customAuthenticationExtensionId")]
        public string CustomAuthenticationExtensionId { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("tenantId")]
        public string TenantId { get { throw null; } set { } }
    }
    public abstract partial class CustomExtensionCalloutRequestTyped<T> : Microsoft.Azure.Entra.Authentication.CustomExtensionCalloutRequest where T : Microsoft.Azure.Entra.Authentication.CustomExtensionData
    {
        protected CustomExtensionCalloutRequestTyped() { }
        protected CustomExtensionCalloutRequestTyped(string tenantId, string resourceAppId, Microsoft.Azure.Entra.Authentication.EventType eventType) { }
        [Newtonsoft.Json.JsonPropertyAttribute("data", Order=2147483647)]
        public T Data { get { throw null; } set { } }
    }
    [Newtonsoft.Json.JsonObjectAttribute(ItemNullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
    public partial class CustomExtensionCalloutResponse
    {
        public CustomExtensionCalloutResponse() { }
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public Microsoft.Azure.Entra.Authentication.CustomExtensionCalloutResponseData Data { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public string Source { get { throw null; } set { } }
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public string Type { get { throw null; } set { } }
    }
    public partial class CustomExtensionCalloutResponseData : Microsoft.Azure.Entra.Authentication.CustomExtensionData
    {
        public CustomExtensionCalloutResponseData(string dataType) { }
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public System.Collections.Generic.IReadOnlyCollection<Microsoft.Azure.Entra.Authentication.EventAction> Actions { get { throw null; } set { } }
    }
    [Newtonsoft.Json.JsonObjectAttribute(ItemNullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
    public abstract partial class CustomExtensionData
    {
        protected CustomExtensionData() { }
        protected CustomExtensionData(string dataType) { }
        [Newtonsoft.Json.JsonPropertyAttribute("@odata.type", Order=-2147483648)]
        public string ODataType { get { throw null; } set { } }
    }
    public abstract partial class DirectoryAttribute
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        protected DirectoryAttribute() { }
        protected DirectoryAttribute(string odataType, Microsoft.Azure.Entra.Authentication.DirectoryAttributeType attributeType) { }
        [Newtonsoft.Json.JsonPropertyAttribute("attributeType")]
        public Microsoft.Azure.Entra.Authentication.DirectoryAttributeType AttributeType { get { throw null; } }
        [Newtonsoft.Json.JsonPropertyAttribute("@odata.type")]
        public string ODataType { get { throw null; } }
        protected static string GetODataName(string odataPostFix) { throw null; }
    }
    [Newtonsoft.Json.JsonConverterAttribute(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DirectoryAttributeType
    {
        [System.Runtime.Serialization.EnumMemberAttribute(Value="builtIn")]
        BuiltIn = 0,
        [System.Runtime.Serialization.EnumMemberAttribute(Value="directorySchemaExtension")]
        DirectorySchemaExtension = 1,
    }
    public abstract partial class DirectoryAttributeTyped<TValue> : Microsoft.Azure.Entra.Authentication.DirectoryAttribute
    {
        [Newtonsoft.Json.JsonConstructorAttribute]
        protected DirectoryAttributeTyped() { }
        protected DirectoryAttributeTyped(string odataType, Microsoft.Azure.Entra.Authentication.DirectoryAttributeType attributeType, TValue value) { }
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public TValue Value { get { throw null; } }
    }
    public abstract partial class EventAction
    {
        protected EventAction() { }
        [Newtonsoft.Json.JsonPropertyAttribute("@odata.type")]
        public string ODataType { get { throw null; } set { } }
        protected static string GetODataName(string actionName, string eventName = null) { throw null; }
    }
    [Newtonsoft.Json.JsonConverterAttribute(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventType
    {
        [Newtonsoft.Json.JsonPropertyAttribute("tokenIssuanceStart")]
        OnTokenIssuanceStart = 0,
    }
    public partial class Int64DirectoryAttribute : Microsoft.Azure.Entra.Authentication.DirectoryAttributeTyped<long?>
    {
        public static readonly string ODataTypeName;
        [Newtonsoft.Json.JsonConstructorAttribute]
        public Int64DirectoryAttribute() { }
        public Int64DirectoryAttribute(Microsoft.Azure.Entra.Authentication.DirectoryAttributeType attributeType, long? value) { }
    }
    public partial class OnTokenIssuanceStartCalloutData : Microsoft.Azure.Entra.Authentication.CustomExtensionCalloutRequestData
    {
        internal OnTokenIssuanceStartCalloutData() { }
    }
    public partial class OnTokenIssuanceStartCalloutRequest : Microsoft.Azure.Entra.Authentication.CustomExtensionCalloutRequestTyped<Microsoft.Azure.Entra.Authentication.OnTokenIssuanceStartCalloutData>
    {
        public OnTokenIssuanceStartCalloutRequest(string tenantId, string resourceAppId) { }
    }
    public partial class ProvideClaimsForTokenAction : Microsoft.Azure.Entra.Authentication.TokenIssuanceStartAction
    {
        public static readonly string LegacyODataTypeName;
        public static readonly string ODataTypeName;
        public ProvideClaimsForTokenAction() { }
        [Newtonsoft.Json.JsonPropertyAttribute("claims")]
        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IList<string>> Claims { get { throw null; } set { } }
    }
    public partial class StringCollectionDirectoryAttribute : Microsoft.Azure.Entra.Authentication.DirectoryAttributeTyped<System.Collections.Generic.IList<string>>
    {
        public static readonly string ODataTypeName;
        [Newtonsoft.Json.JsonConstructorAttribute]
        public StringCollectionDirectoryAttribute() { }
        public StringCollectionDirectoryAttribute(Microsoft.Azure.Entra.Authentication.DirectoryAttributeType attributeType, System.Collections.Generic.IList<string> value) { }
    }
    public partial class StringDirectoryAttribute : Microsoft.Azure.Entra.Authentication.DirectoryAttributeTyped<string>
    {
        public static readonly string ODataTypeName;
        [Newtonsoft.Json.JsonConstructorAttribute]
        public StringDirectoryAttribute() { }
        public StringDirectoryAttribute(Microsoft.Azure.Entra.Authentication.DirectoryAttributeType attributeType, string value) { }
    }
    public abstract partial class TokenIssuanceStartAction : Microsoft.Azure.Entra.Authentication.EventAction
    {
        protected TokenIssuanceStartAction() { }
        protected static string GetODataName(string actionName) { throw null; }
    }
}
