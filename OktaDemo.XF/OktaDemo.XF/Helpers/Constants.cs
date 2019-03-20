namespace OktaDemo.XF.Helpers
{
    public class Constants
    {
        public const string AuthStateKey = "authState";
        public const string AuthServiceDiscoveryKey = "authServiceDiscovery";

        public const string ClientId = "0oajq775tf4HM8h4v0h7";
        public const string RedirectUri = "com.oktapreview.dev-900158:/callback";
        public const string OrgUrl = "https://dev-900158.oktapreview.com";
        public const string AuthorizationServerId = "default";

        public static readonly string DiscoveryEndpoint =
            $"{OrgUrl}/oauth2/{AuthorizationServerId}/.well-known/openid-configuration";


        public static readonly string[] Scopes = new string[] {
            "openid", "profile", "email", "offline_access" };
    }
}
