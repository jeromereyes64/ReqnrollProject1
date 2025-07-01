Feature: EventRegistration

A short summary of the feature

@tag1
Scenario Outline: Register event with valid information
	Given I am on the registration page
	When I enter my name as <name>
	When I enter my email as <email>
	When I enter my age as <age>
	Then I verify successful registration


Examples: 
	| name       | email           | age |
	| John Doe   | jerome@test.com | 30  |
	| Jane Smith | jane@test.com   | 25  |
	| Alice      | alice@test.com  | 22  |