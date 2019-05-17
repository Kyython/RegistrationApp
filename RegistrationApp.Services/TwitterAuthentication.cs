namespace RegistrationApp.Services
{
    public class TwitterAuthentication
    {
        //private IAuthenticationContext _authenticationContext;

        //public void TwitterAuth()
        //{
        //    var appCreds = new ConsumerCredentials("CONSUMER_KEY", "CONSUMER_SECRET");

        //    // Specify the url you want the user to be redirected to
        //    var redirectURL = "http://" + Request.Url.Authority + "/Home/ValidateTwitterAuth";
        //    _authenticationContext = AuthFlow.InitAuthentication(appCreds, redirectURL);

        //    return new RedirectResult(authenticationContext.AuthorizationURL);
        //}

        //public void ValidateTwitterAuth()
        //{
        //    // Get some information back from the URL
        //    var verifierCode = Request.Params.Get("oauth_verifier");

        //    // Create the user credentials
        //    var userCreds = AuthFlow.CreateCredentialsFromVerifierCode(verifierCode, _authenticationContext);

        //    // Do whatever you want with the user now!
        //    ViewBag.User = Tweetinvi.User.GetAuthenticatedUser(userCreds);
        //    return View();
        //}
    }
}
