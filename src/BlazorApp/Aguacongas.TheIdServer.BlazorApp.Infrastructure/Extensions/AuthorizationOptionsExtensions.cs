﻿// Project: Aguafrommars/TheIdServer
// Copyright (c) 2021 @Olivier Lefebvre
using Aguacongas.IdentityServer.Store;
using IdentityModel;

namespace Microsoft.AspNetCore.Authorization
{
    public static class AuthorizationOptionsExtensions
    {
        public static void AddIdentityServerPolicies(this AuthorizationOptions options, bool checkAdminsScope = false, bool showSettings = false)
        {
            options.AddPolicy(SharedConstants.WRITERPOLICY, policy =>
                   policy.RequireAssertion(context => context.User.Identity.IsAuthenticated &&
                    (!checkAdminsScope || context.User.HasClaim(c => c.Type == JwtClaimTypes.Scope && c.Value == SharedConstants.ADMINSCOPE)) &&
                    context.User.IsInRole(SharedConstants.WRITERPOLICY)));
            options.AddPolicy(SharedConstants.READERPOLICY, policy =>
                   policy.RequireAssertion(context => context.User.Identity.IsAuthenticated &&
                    (!checkAdminsScope || context.User.HasClaim(c => c.Type == JwtClaimTypes.Scope && c.Value == SharedConstants.ADMINSCOPE)) &&
                    context.User.IsInRole(SharedConstants.READERPOLICY)));
            options.AddPolicy(SharedConstants.REGISTRATIONPOLICY, policy =>
                   policy.RequireAssertion(context => context.User.Identity.IsAuthenticated &&
                    context.User.IsInRole(SharedConstants.REGISTRATIONPOLICY)));
            options.AddPolicy(SharedConstants.TOKENPOLICY, policy =>
                   policy.RequireAssertion(context => context.User.Identity.IsAuthenticated &&
                    context.User.HasClaim(c => c.Type == JwtClaimTypes.ClientId) &&
                    context.User.HasClaim(c => c.Type == JwtClaimTypes.Scope && c.Value == SharedConstants.TOKENSCOPES)));
            AddSettingsPolicies(options, checkAdminsScope, showSettings);
        }

        private static void AddSettingsPolicies(AuthorizationOptions options, bool checkAdminsScope, bool showSettings)
        {
            options.AddPolicy(SharedConstants.DYNAMIC_CONFIGURATION_WRITTER_POLICY, policy =>
                   policy.RequireAssertion(context => context.User.Identity.IsAuthenticated &&
                    (!checkAdminsScope || context.User.HasClaim(c => c.Type == JwtClaimTypes.Scope && c.Value == SharedConstants.ADMINSCOPE)) &&
                    context.User.IsInRole(SharedConstants.WRITERPOLICY)));
            options.AddPolicy(SharedConstants.DYNAMIC_CONFIGURATION_READER_POLICY, policy =>
                   policy.RequireAssertion(context => context.User.Identity.IsAuthenticated &&
                    (!checkAdminsScope || context.User.HasClaim(c => c.Type == JwtClaimTypes.Scope && c.Value == SharedConstants.ADMINSCOPE)) &&
                    context.User.IsInRole(SharedConstants.READERPOLICY)));
            options.AddPolicy("Read-Settings", policy =>
               policy.RequireAssertion(context => showSettings &&
                context.User.Identity.IsAuthenticated &&
                context.User.IsInRole(SharedConstants.READERPOLICY)));
        }
    }
}
