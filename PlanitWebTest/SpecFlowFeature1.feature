Feature: Ability to make a general enquiry
	In order to contact planit
	As a potential client
	I want to be able to make a general enquiry
@mytag
Scenario: Cannot submit a general enquiry without a Job Title 
	Given I have navigated to the Planit home webpage
	And I have clicked on Contact Us
	And I have entered Krish into firstname
	And I have entered broo into lastname
	When I press Submit
	Then the result should display a error 

Scenario Outline: Cannot submit a general enquiry without a Job Title -- data driven
	Given I have navigated to the Planit home webpage
	And I have clicked on Contact Us
	And I have entered <firstName> into firstname
	And I have entered <lastName> into lastname
	When I press Submit
	Then the result should display a error 

	Examples:
	| firstName | lastName |
	| aaron     | kkkkk    |
	| kdkdkdk   | dkdkdkdk |
	| jackson   | Ung      | 

