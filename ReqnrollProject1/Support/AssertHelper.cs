using OpenQA.Selenium;
using FluentAssertions;
using System;

namespace ReqnrollProject.Utils
{
    public static class AssertHelper
    {
        public static void ShouldBeDisplayed(IWebElement element, string elementName = "")
        {
            try
            {
                Console.WriteLine($"[ASSERT] Expecting element '{elementName}' to be DISPLAYED");
                element.Displayed.Should().BeTrue($"Element '{elementName}' should be displayed.");
                Console.WriteLine($"[PASS] '{elementName}' is displayed");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[FAIL] Element '{elementName}' is not displayed.");
                Console.WriteLine($"[ERROR] {ex.Message}");
                throw;
            }
        }

        public static void ShouldContainText(IWebElement element, string expectedText, string elementName = "")
        {
            try
            {
                string actualText = element.Text;
                Console.WriteLine($"[ASSERT] Expecting '{elementName}' to CONTAIN text: '{expectedText}'");
                actualText.Should().Contain(expectedText, $"Element '{elementName}' should contain '{expectedText}'");
                Console.WriteLine($"[PASS] '{elementName}' contains text: '{expectedText}'");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[FAIL] Text assertion failed for '{elementName}'.");
                Console.WriteLine($"[ERROR] {ex.Message}");
                throw;
            }
        }
        public static void ShouldBeVisible(IWebElement element, string elementName = "")
        {
            try
            {
                Console.WriteLine($"[ASSERT] Expecting element '{elementName}' to be VISIBLE");

                // Visible in Selenium = Displayed AND present in DOM
                bool isVisible = element.Displayed;

                isVisible.Should().BeTrue($"Element '{elementName}' should be visible.");
                Console.WriteLine($"[PASS] '{elementName}' is visible");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine($"[FAIL] Element '{elementName}' was not found in the DOM.");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[FAIL] Visibility check failed for '{elementName}'.");
                Console.WriteLine($"[ERROR] {ex.Message}");
                throw;
            }
        }

    }
}
