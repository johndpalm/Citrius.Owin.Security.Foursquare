﻿using System;
using Microsoft.Owin.Security;
using Citrius.Owin.Security.Foursquare;

namespace Owin
{
    public static class FoursquareAuthenticationExtensions
    {
        public static IAppBuilder UseFoursquareAuthentication(this IAppBuilder app, FoursquareAuthenticationOptions options)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            app.Use(typeof(FoursquareAuthenticationMiddleware), app, options);
            return app;
        }

        public static IAppBuilder UseFoursquareAuthentication(
            this IAppBuilder app,
            string clientId,
            string clientSecret)
        {
            return UseFoursquareAuthentication(
                app,
                new FoursquareAuthenticationOptions
                {
                    ClientId = clientId,
                    ClientSecret = clientSecret
                });
        }
    }
}
