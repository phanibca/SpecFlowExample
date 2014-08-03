Feature: LanguageChange
	In order to provide multilingual capability
	to the applicatin, I want to change the 
	language of the application

@mytag
Scenario: Change Language to Dutch
	Given I have logged into 'CPATestApplication' with 'CPATestUser'
	And I have clicked on 'General' menu
	And I have clicked on 'Preferences' submenu
	And I press Modify in Preferences
	And I change PreferredLanguage to 'Netherlands' and save
	Then I should see Preferences on page in 'Dutch'
