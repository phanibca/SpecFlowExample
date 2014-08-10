Feature: Login
	In order to work on CPA
	As a user
	I want to be able to log into the applicatoin

@mytag
# View Function Profile menu link in Beheer
Scenario: Default homepage should be visible on successful login
	Given I have 'CPATestURL' opened
	When 'CAPTestUser1' is logged in
	Then PageTitle should be 'Home'

Scenario: Only Authorized widgets should be visible when logged in
	Given I have 'CPATestURL' opened
	When 'CAPTestUser1' is logged in
	Then only valid widgets should be visible