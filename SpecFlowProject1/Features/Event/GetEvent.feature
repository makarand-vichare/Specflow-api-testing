Feature: GetEvent
	Simple calculator for adding two numbers

@mytag
Scenario: Get a Event Successfully
	Given use the http client
	Then use the event is id
	When get a event
	Then the response code should be 200