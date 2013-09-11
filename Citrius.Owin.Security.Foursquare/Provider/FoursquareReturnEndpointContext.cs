using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Provider;
using System.Collections.Generic;

namespace Citrius.Owin.Security.Foursquare
{
    public class FoursquareReturnEndpointContext : ReturnEndpointContext
    {
        public FoursquareReturnEndpointContext(
            IOwinContext context,
            AuthenticationTicket ticket,
            IDictionary<string, string> errorDetails)
            : base(context, ticket, errorDetails)
        {
        }
    }
}
