using OpenQA.Selenium;
using ReqnrollProject.Utils;

namespace ReqnrollProject1.Pages
{
    public class CheckoutItemPage
    {
        private readonly IWebDriver _driver;

        // Constructor receives the shared WebDriver
        public CheckoutItemPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Element locators using ID (could also use XPath/CSS if needed)
        private IWebElement firstItemAddToCartButton => _driver.FindElement(By.XPath("//*[contains(text(),'Add to cart')][1]"));
        private IWebElement cartIcon => _driver.FindElement(By.XPath("//a[@class='shopping_cart_link']"));
        private IWebElement cartPage => _driver.FindElement(By.XPath("//span[contains(text(), 'Your Cart')]"));
        private IWebElement checkoutButton => _driver.FindElement(By.XPath("//button[@id='checkout']"));
        private IWebElement checkOutPage => _driver.FindElement(By.XPath("//span[contains(text(), 'Checkout: Your Information')]"));
        private IWebElement firstNameField => _driver.FindElement(By.XPath("//input[@id='first-name']"));
        private IWebElement lastNameField => _driver.FindElement(By.XPath("//input[@id='last-name']"));
        private IWebElement postalCodeField => _driver.FindElement(By.XPath("//input[@id='postal-code']"));
        private IWebElement continueButton => _driver.FindElement(By.XPath("//input[@id='continue']"));
        private IWebElement checkOutOverview => _driver.FindElement(By.XPath("//span[contains(text(), 'Checkout: Overview')]"));
        private IWebElement finishButton => _driver.FindElement(By.XPath("//button[@id='finish']"));
        private IWebElement confirmationMessage => _driver.FindElement(By.XPath("//div[contains(text(), 'Your order has been dispatched')]"));

        // Method to add the first item to the cart
        public void AddFirstItemToCart()
        {
            Common.Click(firstItemAddToCartButton);
        }

        // Method to go to the cart page
        public void GoToCartAndCheckout()
        {
            Common.Click(cartIcon);
            AssertHelper.ShouldBeVisible(cartPage);
            Common.Click(checkoutButton);
        }

        public void FillCheckoutDetails(string firstName, string lastName, string postalCode)
        {
            AssertHelper.ShouldBeVisible(checkOutPage);
            Common.Clear(firstNameField);
            Common.SendKeys(firstNameField, firstName);
            Common.Clear(lastNameField);
            Common.SendKeys(lastNameField, lastName);
            Common.Clear(postalCodeField);
            Common.SendKeys(postalCodeField, postalCode);
            Common.Click(continueButton);
            Common.Pause(1); // Wait for the next page to load
        }

        public void CompleteOrder()
        {
            AssertHelper.ShouldBeVisible(checkOutOverview);
            Common.Click(finishButton);
            AssertHelper.ShouldBeVisible(confirmationMessage);
        }
    }
}
