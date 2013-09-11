using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Provider;
using Newtonsoft.Json.Linq;
using System;
using System.Security.Claims;

namespace Citrius.Owin.Security.Foursquare
{
    public class FoursquareAuthenticatedContext : BaseContext
    {
        public FoursquareAuthenticatedContext(IOwinContext context, JObject user, string accessToken)
            : base(context)
        {
            
            User = user;
            AccessToken = accessToken;

            Id = TryGetValue(user, "id");
            FirstName = TryGetValue(user, "firstName");
            LastName = TryGetValue(user, "lastName");
            Name = FirstName + " " + LastName;
            Gender = TryGetValue(user, "gender");
            Photo = TryGetValue(user, "photo");
            Friends = TryGetValue(user, "friends");
            HomeCity = TryGetValue(user, "homeCity");
            Bio = TryGetValue(user, "bio");
            Contact = TryGetValue(user, "contact");
            Phone = TryGetValue(JObject.Parse(Contact), "phone");
            Email = TryGetValue(JObject.Parse(Contact), "email");
            Twitter = TryGetValue(JObject.Parse(Contact), "twitter");
            Facebook = TryGetValue(JObject.Parse(Contact), "facebook");
            Badges = TryGetValue(user, "badges");
            Mayorships = TryGetValue(user, "mayorships");
            Checkins = TryGetValue(user, "checkins");
            Photos = TryGetValue(user, "photos");
            Scores = TryGetValue(user, "scores");
            Link = "https://foursquare.com/user/" + Id;
        }

        public JObject User { get; private set; }
        public string AccessToken { get; private set; }
        public string Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public string Photo { get; private set; }
        public string Friends { get; private set; }
        public string HomeCity { get; private set; }
        public string Bio { get; private set; }
        public string Contact { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Twitter { get; private set; }
        public string Facebook { get; private set; }
        public string Badges { get; private set; }
        public string Mayorships { get; private set; }
        public string Checkins { get; private set; }
        public string Photos { get; private set; }
        public string Scores { get; private set; }
        public string Link { get; private set; }

        public ClaimsIdentity Identity { get; set; }
        public AuthenticationProperties Properties { get; set; }

        private static string TryGetValue(JObject user, string propertyName)
        {
            JToken value;
            return user.TryGetValue(propertyName, out value) ? value.ToString() : null;
        }

    }




}
