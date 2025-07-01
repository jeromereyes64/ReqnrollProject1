Feature: Login

A short summary of the feature

@regression @smoke
Scenario: Login with valid credentials
	Given I am on the login page
	When I enter my username and password
	When I click login
	Then I verify successful login