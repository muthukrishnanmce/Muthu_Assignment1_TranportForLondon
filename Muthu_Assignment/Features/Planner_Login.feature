Feature: Planner validations



Background:
		Given I launch TFL Planner home page


Scenario: Validate if the locations are valid - Verify that a valid journey can be planned using the widget. 
	When I enter source as "London Bridge" and destination as "Abbey Wood"
	Then I validate if the locations are "valid"

Scenario: Validate if the locations are Invalid - Verify that the widget is unable to provide results when an invalid journey is planned.
	When I enter source as "sdgsdgsd" and destination as "sdgsdhgdhsd"
	Then I validate if the locations are "invalid"

Scenario: Validate if widget is unable to plan journey when no locations entered
	Then I validate if I am not able to plan journey

Scenario: Validate if journey can be amended by clicking on Edit journey
	When I enter source as "London Bridge" and destination as "Abbey Wood"
	And I update journey as Arriving
	Then I validate if the journey is updated

	Scenario: Validate if recent journey is displayed
	When I enter source as "London Bridge" and destination as "Abbey Wood"
	And I navigate back to previous page
	And I click on Recents
	Then I valide if I can see recent journey for source "London Bridge" and destination as "Abbey Wood"