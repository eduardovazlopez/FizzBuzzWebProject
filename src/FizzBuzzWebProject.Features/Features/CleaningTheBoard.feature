Feature: CleaningTheBoard
	Clean the board after running the FizzBuzz Test

Scenario: Cleaning the board
	Given I am at the Home page
    And the FizzBuzz Test is been executed
    When I click the Clean Board button
    Then all numbers are erased from the Home page