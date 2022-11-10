using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new List<IdentityResource>
            {
                        new IdentityResources.OpenId(),
                        new IdentityResources.Profile(),

            };

        public static IEnumerable<ApiResource> Apis =>
            new List<ApiResource>
            {
                new ApiResource("ShopApi",new List<string>(){"name" }),

            };


        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                        new Client
                        {
                            ClientId = "MobileClient",
                            AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                            ClientSecrets =
                            {
                                new Secret("secret".Sha256())
                            },

                            AllowedScopes = { "ShopApi", "openid","profile" }

                        },

                    };
           };



    
}
