using ICSharpCode.SharpZipLib.Core;
using Reqnroll;
using ReqnrollProject.Pages;
using ReqnrollProject.Utils;
using ReqnrollProject1.Pages;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public class SauceLabsLoginAndCheckoutStepDefinitions
    {

        private readonly LoginPage _loginPage;
        private readonly CheckoutItemPage _checkoutItemPage;

        // Constructor to inject the page object
        public SauceLabsLoginAndCheckoutStepDefinitions(LoginPage loginPage, CheckoutItemPage checkoutItemPage)
        {
            _loginPage = loginPage;
            _checkoutItemPage = checkoutItemPage;
        }

        [Given("I am signed in as a standard user")]
        public void GivenIAmSignedInAsAStandardUser()
        {
            _loginPage.PerformLogin(TestData.Users.StandardUser, TestData.Users.StandardPassword);
        }

        [When("I add the first item to the cart")]
        public void WhenIAddTheFirstItemToTheCart()
        {
            _checkoutItemPage.AddFirstItemToCart();
        }

        [When("I go to the cart page")]
        public void WhenIGoToTheCartPage()
        {
            _checkoutItemPage.GoToCartAndCheckout();
        }

        [When("I proceed to checkout")]
        public void WhenIProceedToCheckout()
        {
            Console.WriteLine("Proceeding to checkout...");
        }

        [When("I fill in checkout details with first name {string}, last name {string}, and postal code {string}")]
        public void WhenIFillInCheckoutDetailsWithFirstNameLastNameAndPostalCode(string jerome, string reyes, string p2)
        {
            _checkoutItemPage.FillCheckoutDetails(TestData.CheckoutDetails.FirstName, TestData.CheckoutDetails.LastName, TestData.CheckoutDetails.PostalCode);
        }

        [When("I complete the order")]
        public void WhenICompleteTheOrder()
        {
            Console.WriteLine("Completing the order...");
        }

        [Then("I should see the confirmation message {string}")]
        public void ThenIShouldSeeTheConfirmationMessage(string p0)
        {
            _checkoutItemPage.CompleteOrder();
        }
    }
}
