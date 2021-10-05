Feature: PostEvent
	Simple calculator for adding two numbers

@mytag
Scenario: Create a Event Successfully
	Given use the http client
	Then use a new event object
	When post a event
	Then the response code should be 200