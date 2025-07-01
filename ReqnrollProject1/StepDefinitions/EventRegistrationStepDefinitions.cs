using System;
using Reqnroll;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public class EventRegistrationStepDefinitions
    {
        [Given("I am on the registration page")]
        public void GivenIAmOnTheRegistrationPage()
        {
            Console.WriteLine("Navigated to registration page.");
            // Add your navigation logic here
        }

        [When("I enter my name as (.*)")]
        public void WhenIEnterMyNameAs(string name)
        {
            Console.WriteLine("Name entered: " + name);
            // Simulate entering name
        }

        [When("I enter my email as (.*)")]
        public void WhenIEnterMyEmailAs(string email)
        {
            Console.WriteLine("Email entered: " + email);
            // Simulate entering email
        }

        [When("I enter my age as (.*)")]
        public void WhenIEnterMyAgeAs(int age)
        {
            Console.WriteLine($"Age entered: " + age);
            // Simulate entering age
        }

        [Then("I verify successful registration")]
        public void ThenIVerifySuccessfulRegistration()
        {
            Console.WriteLine("Verified successful registration.");
            // Add verification logic here
        }
    }
}