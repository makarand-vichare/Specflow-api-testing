Feature: DeleteEvent
	Simple calculator for adding two numbers

@mytag
Scenario: Delete Event Successfully
	Given the event id
	And the http client
	When deleted the selected event
	Then the response code should be 200