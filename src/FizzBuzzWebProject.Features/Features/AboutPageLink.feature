Feature: AboutPageLink
	Navegate to the About page

Scenario: Navegate to the About page
	Given I am at the Home page
    When I click the About link at the Navbar
    Then the description of the FizzBuzz Test is displayed
