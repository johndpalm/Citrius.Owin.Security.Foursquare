using System.Threading.Tasks;

namespace Citrius.Owin.Security.Foursquare
{
    public interface IFoursquareAuthenticationProvider
    {
        Task Authenticated(FoursquareAuthenticatedContext context);
        Task ReturnEndpoint(FoursquareReturnEndpointContext context);
    }
}
