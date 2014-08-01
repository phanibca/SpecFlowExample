Feature: Login
	In order to work on CPA
	As a user
	I want to be able to log into the applicatoin

@mytag
# View Function Profile menu link in Beheer
Scenario: Default homepage should be visible on successful login
	Given I have the url 'https://proxy.paymentslab.nl/cpa/' opened
	When 'WB65390918' is logged in
	Then PageTitle should be 'Home'