using OpenQA.Selenium;
using System;

namespace ReqnrollProject.Utils
{
    public static class Common
    {
        public static void Click(IWebElement element, string elementName = "")
        {
            try
            {
                Console.WriteLine($"[ACTION] Clicking on: {elementName}");
                element.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Failed to click on {elementName}: {ex.Message}");
                throw;
            }
        }

        public static void SendKeys(IWebElement element, string value, string elementName = "")
        {
            try
            {
                Console.WriteLine($"[ACTION] Typing into: {elementName} → '{value}'");
                element.SendKeys(value);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Failed to send keys to {elementName}: {ex.Message}");
                throw;
            }
        }

        public static void Clear(IWebElement element, string elementName = "")
        {
            try
            {
                Console.WriteLine($"[ACTION] Clearing: {elementName}");
                element.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Failed to clear {elementName}: {ex.Message}");
                throw;
            }
        }
    }
}
