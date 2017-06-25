using System;
using TechTalk.SpecFlow;

namespace SpecFlowGettingStartedUT
{
    [Binding]
    public class AddingDoctorDetaiSteps
    {
        [Given(@"""(.*)"" navigate to ""(.*)""")]
        public void GivenNavigateTo(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enters enters ""(.*)""")]
        public void GivenEntersEnters(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enters ""(.*)""")]
        public void GivenEnters(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enters invalid ""(.*)""")]
        public void GivenEntersInvalid(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"clicked on ""(.*)"" button")]
        public void WhenClickedOnButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"System displays message ""(.*)""")]
        public void ThenSystemDisplaysMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"click on ""(.*)"" button will redirect to ""(.*)""")]
        public void ThenClickOnButtonWillRedirectTo(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"System displays validation message ""(.*)""")]
        public void ThenSystemDisplaysValidationMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"click on ""(.*)"" button puts the focus to ""(.*)"" Field\.")]
        public void ThenClickOnButtonPutsTheFocusToField_(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
