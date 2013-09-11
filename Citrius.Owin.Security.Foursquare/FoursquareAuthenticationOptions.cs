using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using Microsoft.Owin;
using Microsoft.Owin.Security;

namespace Citrius.Owin.Security.Foursquare
{
    public class FoursquareAuthenticationOptions : AuthenticationOptions
    {
        public const string Scheme = "Foursquare";

        public FoursquareAuthenticationOptions()
            : base(Scheme)
        {
            Caption = Scheme;
            ReturnEndpointPath = "/signin-foursquare";
            AuthenticationMode = AuthenticationMode.Passive;
            BackchannelTimeout = TimeSpan.FromSeconds(60);
            Scope = new List<string>();
        }

        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public ICertificateValidator BackchannelCertificateValidator { get; set; }
        public TimeSpan BackchannelTimeout { get; set; }
        public HttpMessageHandler BackchannelHttpHandler { get; set; }

        public string Caption
        {
            get { return Description.Caption; }
            set { Description.Caption = value; }
        }

        public string ReturnEndpointPath { get; set; }

        public string SignInAsAuthenticationType { get; set; }

        public IFoursquareAuthenticationProvider Provider { get; set; }

        public ISecureDataFormat<AuthenticationProperties> StateDataFormat { get; set; }

        public IList<string> Scope { get; private set; }

    }
}
