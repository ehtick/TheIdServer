﻿using Aguacongas.IdentityServer.Saml2p.Duende.Services.Store;
using Duende.IdentityServer.Models;
using ITfoxtec.Identity.Saml2;
using ITfoxtec.Identity.Saml2.Http;
using System.Security.Claims;

namespace Aguacongas.IdentityServer.Saml2p.Duende.Services.Validation;
public class SignInValidationResult<T> where T : Saml2Binding<T>
{
    public Saml2Request? Saml2Request { get; set; }
    public string? Error { get; set; }
    public string? ErrorMessage { get; set; }
    public Client? Client { get; set; }
    public RelyingParty? RelyingParty { get; set; }
    public bool SignInRequired { get; set; }
    public ClaimsPrincipal? User { get; set; }
    public T? Saml2Binding { get; set; }
    public HttpRequest? GerericRequest { get;  set; }
}
