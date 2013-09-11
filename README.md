# Citrius.Owin.Security.Foursquare
Citrius.Owin.Security.Foursquare is a [OWIN](http://owin.org/) [Katana](http://katanaproject.codeplex.com) authentication provider for [Foursquare](https://developer.foursquare.com).

## NuGet Package Available

	Install-Package Citrius.Owin.Security.Foursquare -Pre

	Add the following to Startup.Auth.cs (VS2013) or AuthConfig.cs (VS2012):

            app.UseFoursquareAuthentication(
                clientId: "",
                clientSecret: "");

Create an app and get your unique Client ID and Client Secret from: [https://developer.foursquare.com](https://developer.foursquare.com)

## License
[Apache v2 License](https://github.com/johndpalm/Citrius.Owin.Security.Foursquare/blob/master/LICENSE.txt)