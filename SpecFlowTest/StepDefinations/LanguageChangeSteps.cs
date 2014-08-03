using System;
using TechTalk.SpecFlow;

namespace SpecFlowTest
{
    [Binding]
    public class LanguageChangeSteps
    {
        [Given(@"I have logged into '(.*)' with '(.*)'")]
public void GivenIHaveLoggedIntoWith(string p0, string p1)
{
    ScenarioContext.Current.Pending();
}

        [Given(@"I have clicked on '(.*)' menu")]
public void GivenIHaveClickedOnMenu(string p0)
{
    ScenarioContext.Current.Pending();
}

        [Given(@"I have clicked on '(.*)' submenu")]
public void GivenIHaveClickedOnSubmenu(string p0)
{
    ScenarioContext.Current.Pending();
}

        [Given(@"I press Modify in Preferences")]
public void GivenIPressModifyInPreferences()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"I change PreferredLanguage to '(.*)' and save")]
public void GivenIChangePreferredLanguageToAndSave(string p0)
{
    ScenarioContext.Current.Pending();
}

        [Then(@"I should see Preferences on page in '(.*)'")]
public void ThenIShouldSeePreferencesOnPageIn(string p0)
{
    ScenarioContext.Current.Pending();
}
    }
}
