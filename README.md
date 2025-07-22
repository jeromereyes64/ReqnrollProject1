# 🧪 ReqnrollProject1 - BDD UI Test Automation (Selenium + Reqnroll + .NET)

This is a **.NET-based BDD UI test automation framework** using **Reqnroll (SpecFlow fork)**, **Selenium WebDriver**, and **NUnit**. It demonstrates best practices in structuring automated UI test cases using the **Page Object Model** (POM) and Reqnroll step definitions.

---

## ✅ Tech Stack

- **Language:** C# (.NET 6 or 7)
- **Test Framework:** Reqnroll (SpecFlow compatible)
- **Runner:** NUnit
- **Browser Automation:** Selenium WebDriver
- **Build System:** Visual Studio / dotnet CLI

---

## 📂 Project Structure

```
ReqnrollProject1/
├── Features/                   # Gherkin Feature Files
│   └── Login.feature
│
├── Pages/                      # Page Object classes (e.g., locators + actions)
│   └── LoginPage.cs
│
├── StepDefinitions/           # Step definitions implementing Gherkin steps
│   └── LoginSteps.cs
│
├── Hooks/                     # Hooks (before/after scenarios, test setup/teardown)
│   └── Hooks.cs
│
├── Drivers/                   # WebDriver and browser factory setup
│   └── DriverFactory.cs
│
├── app.config                 # Test run config (optional)
└── ReqnrollProject1.csproj    # Project file
```

---

## 🧰 Prerequisites

- .NET 6 SDK or higher
- Visual Studio 2022+ with NUnit and .NET support
- Reqnroll extension (install via NuGet)
- Chrome browser (or Edge/Firefox as needed)

---

## 🔧 Setup Instructions

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/jeromereyes64/ReqnrollProject1.git
cd ReqnrollProject1
```

### 2️⃣ Restore Dependencies

```bash
dotnet restore
```

Or use **Visual Studio → Manage NuGet Packages** to install:

- `Reqnroll`
- `Selenium.WebDriver`
- `NUnit`
- `Selenium.Support`

### 3️⃣ Run Tests

```bash
dotnet test
```

Or run through **Test Explorer** in Visual Studio.

---

## 📄 Sample Feature File

```gherkin
Feature: Login Functionality

  Scenario: Valid user logs in successfully
    Given the user is on the login page
    When the user enters valid credentials
    And the user clicks the login button
    Then the user should be redirected to the dashboard
```

---

## 🧪 Sample Step Definition

```csharp
[Binding]
public class LoginSteps
{
    private readonly LoginPage _loginPage;

    public LoginSteps()
    {
        _loginPage = new LoginPage();
    }

    [Given(@"the user is on the login page")]
    public void GivenUserIsOnLoginPage()
    {
        _loginPage.Navigate();
    }

    [When(@"the user enters valid credentials")]
    public void WhenUserEntersValidCredentials()
    {
        _loginPage.EnterUsername("admin");
        _loginPage.EnterPassword("password123");
    }

    [Then(@"the user should be redirected to the dashboard")]
    public void ThenUserShouldBeRedirected()
    {
        Assert.IsTrue(_loginPage.IsDashboardVisible());
    }
}
```

---

## 💡 Highlights

- ✅ Clean folder structure using POM
- ✅ NUnit + Reqnroll integration
- ✅ Scalable for cross-browser testing
- ✅ Modular step definitions
- ✅ Works well with CI tools (Azure DevOps, GitHub Actions, etc.)

---

## 📌 Author

**Jerome Reyes**  
🔗 [jeromereyes64 GitHub](https://github.com/jeromereyes64)  
💬 Feel free to fork and improve!
