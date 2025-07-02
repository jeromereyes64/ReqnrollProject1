using Reqnroll;
using ReqnrollProject.Pages;
using FluentAssertions;

namespace ReqnrollProject.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;

        // Constructor to inject the page object
        public LoginSteps(LoginPage loginPage)
        {
            _loginPage = loginPage;
        }

        [Given("I am on the login form")]
        public void GivenIAmOnTheLoginForm()
        {
            _loginPage.GoToLoginPage();
        }

        [When("I enter username and password")]
        public void WhenIEnterUsernameAndPassword()
        {
            _loginPage.EnterUsername("standard_user");           // replace with your test data
            _loginPage.EnterPassword("secret_sauce");     // replace with your test data
        }

        [When("I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            _loginPage.ClickLogin();
        }

        [Then("I should be redirected to the home page")]
        public void ThenIShouldBeRedirectedToTheHomePage()
        {
            _loginPage.IsDashboardDisplayed().Should().BeTrue("the user should be redirected to the home page");
        }
    }
}