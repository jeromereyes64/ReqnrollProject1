using System;
using Reqnroll;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            Console.WriteLine("Test Jerome");
            //throw new PendingStepException();
        }

        [When("I enter my username and password")]
        public void WhenIEnterMyUsernameAndPassword()
        {
            Console.WriteLine("Test Jerome");
            //throw new PendingStepException();
        }

        [When("I click login")]
        public void WhenIClickLogin()
        {
            Console.WriteLine("Test Jerome");
            //throw new PendingStepException();
        }

        [Then("I verify successful login")]
        public void ThenIVerifySuccessfulLogin()
        {
            Console.WriteLine("Test Jerome");
            //throw new PendingStepException();
        }
    }
}
