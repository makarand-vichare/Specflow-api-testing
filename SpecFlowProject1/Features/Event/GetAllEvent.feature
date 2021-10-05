Feature: GetAllEvent
	Simple calculator for adding two numbers

@mytag
Scenario: Get all Event Successfully
	Given the http client
	When get all events
	Then the response code should be 200