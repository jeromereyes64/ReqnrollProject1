@regression
Feature: Login Feature
  As a user
  I want to log in with valid credentials
  So that I can access the dashboard

  Scenario: Successful sign in with credentials
    Given I am on the login form
    When I enter username and password
    And I click the sign in button
    Then I should be redirected to the home page