Feature: Login functionality
As a user
I want to log in with valid credentials
So that I can access the dashboard

@Sanity
Scenario: Successful login with valid credentials
    Given I am on the login page
    When I enter valid username and password
    And I click the login button
    Then I should be redirected to the dashboard