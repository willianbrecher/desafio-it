Feature: RestaurantBehavior

@menuDisplay

Scenario: Viewing available dishes
	Given the user is on the homepage and the count of dishes list is <Count>
	When the page loads
	Then the user should see a list of dishes with their names, descriptions, prices, and photos

	Examples:
	| Count |
	| 0     |

Scenario: No dishes available
	Given the user is on the homepage
	And no dishes are available
	When the page loads
	Then the user should see a message "No dishes available at the moment"

@orderPlacement

Scenario: Selecting dishes from the menu
	Given the user is viewing the menu
	When the user selects a dish
	And specifies a quantity
	Then the dish should be added to the user's order

Scenario: Viewing total order cost
	Given the user has selected dishes
	When the user views their order summary
	Then the total cost of the selected dishes should be displayed

Scenario: Submitting an order
	Given the user has selected dishes
	When the user clicks on "Place Order"
	Then the order should be saved in the database
	And the user should be redirected to the order status page

@realtimeOrderStatus

Scenario: Viewing initial order status
	Given the user has placed an order
	When they are redirected to the order status page
	Then the order status should display "Received"

Scenario: Viewing updated order status in real-time
	Given the user is on the order status page
	And the restaurant staff updates the order status
	When the status is changed to "Preparing" or "Ready to Serve"
	Then the user should see the updated order status in real-time


@adminInterface

Scenario: Viewing incoming orders
	Given a restaurant staff member is on the admin interface
	When a new order is placed
	Then the staff should see the new order with its details

Scenario: Updating order status
	Given a restaurant staff member is viewing an incoming order
	When they select a new status for the order
	And click on "Update Status"
	Then the order status should be updated in the database
	And users should be notified in real-time


@menuItemDetails

Scenario: Viewing detailed information of a dish
	Given the user is viewing the menu
	When the user clicks on a dish name or photo
	Then a detailed description of the dish, including ingredients, should be displayed

  
@orderValidation

Scenario: Placing an order without selecting any dishes
	Given the user has not selected any dishes
	When the user clicks on "Place Order"
	Then an error message should be displayed "Please select at least one dish to order"
	And the order should not be submitted
  
Scenario: Ordering an out-of-stock item
	Given the user has selected a dish that is out of stock
	When the user tries to place the order
	Then an error message should be displayed "One or more items in your order are out of stock"
	And the order should not be submitted

@inventoryManagement

Scenario: Marking a dish as out of stock
	Given a restaurant staff member is on the admin interface
	When they mark a dish as out of stock
	Then users should not be able to order that dish
  
Scenario: Adding a new dish to the menu
	Given a restaurant staff member is on the admin interface
	When they add a new dish with all required details
	Then the new dish should be displayed in the user's menu view
  
  
@userFeedback

Scenario: Rating a dish after an order
	Given the user has received their dishes
	When the user goes to the order history page
	Then they should be able to rate each dish they ordered

Scenario: Leaving a comment for the restaurant
	Given the user has received their dishes
	When the user goes to the order history page
	And clicks on "Leave feedback"
	Then they should be able to leave a comment about their overall experience

@UserAccountManagement

Scenario: Signing up for a new account
	Given the user is on the signup page
	When they enter valid credentials and submit
	Then a new user account should be created
	And the user should be logged in

Scenario: Logging into an existing account
	Given the user is on the login page
	When they enter valid credentials and submit
	Then the user should be logged in
	And be redirected to the homepage

Scenario: Resetting forgotten password
	Given the user is on the login page
	And they forgot their password
	When they click on "Forgot Password"
	And enter their email
	Then they should receive an email with password reset instructions

@dishRecommendationSystem

Scenario: Suggesting dishes based on a single dish selection
	Given the user has selected a dish from the menu
	When they look for recommendations
	Then the system should suggest up to 2 dishes that other users frequently ordered with the selected dish and that are not out of stock.

Scenario: Suggesting dishes based on multiple dish selections
	Given the user has selected multiple dishes from the menu
	When they look for recommendations
	Then the system should suggest up to 3 dishes that other users frequently ordered with the selected set of dishes and that are not out of stock.

Scenario: No recommendations available
	Given the user has selected a dish from the menu
	And no other dishes have been frequently ordered with it
	When they look for recommendations
	Then the system should display "No recommendations available for this selection"
  
Scenario: Update co-occurrence graph after an order
	Given a user places an order with multiple dishes
	When the order is successfully placed
	Then the system should update the co-occurrence graph based on the dishes in the order. This update may include deleting edges with small weights.

Scenario: Suggest a whole meal based on a single selection
	Given the user selects a particular that is not out of stock.
	When the user asks for a meal suggestion containing that dish.
	Then the system should suggest the most likely full meal, with starter, main, dessert dishes and a single beverage. The full meal should be chosen from all possible meals that include the reference dish.

