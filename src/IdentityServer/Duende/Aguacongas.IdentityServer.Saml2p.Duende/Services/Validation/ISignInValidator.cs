﻿using ITfoxtec.Identity.Saml2;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Aguacongas.IdentityServer.Saml2p.Duende.Services.Validation;
public interface ISignInValidator
{
    Task<SignInValidationResult<Saml2SoapEnvelope>> ValidateArtifactRequestAsync(HttpRequest request);
    Task<SignInValidationResult<Saml2RedirectBinding>> ValidateLoginAsync(HttpRequest request, ClaimsPrincipal user);

    Task<SignInValidationResult<Saml2PostBinding>> ValidateLogoutAsync(HttpRequest request);
}
