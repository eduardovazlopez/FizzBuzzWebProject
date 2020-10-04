Feature: FizzBuzzTest
	Run the FizzBuzz Test and check the result

Scenario: Run FizzBuzz Test
	Given I am at the Home page
    When I click the Execute FizzBuzz Test button
    Then numbers from 1 to 100 are printed
    And numbers multiples of three prints Fizz
    And numbers multiples of five prints Buzz
    And numbers multiples of three and five prints FizzBuzz