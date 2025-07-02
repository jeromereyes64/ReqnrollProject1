@smoke
Feature: Sauce Labs Login and Checkout
  As a standard user
  I want to log in, add an item to cart, and complete checkout
  So that I can verify the end-to-end eCommerce flow

 Background: 
  Given I am signed in as a standard user

  Scenario: Add item to cart and complete checkout
    When I add the first item to the cart
    And I go to the cart page
    And I proceed to checkout
    And I fill in checkout details with first name "Jerome", last name "Reyes", and postal code "1000"
    And I complete the order
    Then I should see the confirmation message "Thank you for your order!"