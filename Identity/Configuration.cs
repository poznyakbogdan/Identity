using IdentityModel;
using IdentityServer4.Models;

namespace Identity;

public static class Configuration
{
    public static IEnumerable<ApiResource> ApiResources => new[]
    {
        new ApiResource("TransactionsApi", "Transactions API", new[] { JwtClaimTypes.Name })
        {
            Scopes = { "WebApi" }
        }
    };
    public static IEnumerable<IdentityResource> IdentityResources => new List<IdentityResource>()
    {
        new IdentityResources.OpenId(),
        new IdentityResources.Profile()
    };
    
    public static IEnumerable<ApiScope> ApiScopes => new[] { new ApiScope("WebApi", "Web API") };
    public static IEnumerable<Client> ApiClients => new[] { new Client()
    {
        ClientId = "",
        ClientName = "",
        AllowedGrantTypes = GrantTypes.Code,
        RequireClientSecret = false,
        RequirePkce = true,
        RedirectUris =
        {
            "http:// .../signin-oidc"
        },
        AllowedCorsOrigins =
        {
            "http:// .../signout-oidc"
        },
        AllowedScopes =
        {
            IdentityServer4.IdentityServerConstants.StandardScopes.OpenId,
            IdentityServer4.IdentityServerConstants.StandardScopes.Profile,
        },
        AllowAccessTokensViaBrowser = true
    } };
}