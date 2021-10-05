using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Features.Event
{
    [Binding]
    [Scope(Feature ="DeleteEvent")]
    public class DeleteEventSteps
    {
        [Given(@"the event id")]
        public void GivenTheEventId()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the http client")]
        public void GivenTheHttpClient()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"deleted the selected event")]
        public void WhenDeletedTheSelectedEvent()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the response code should be (.*)")]
        public void ThenTheResponseCodeShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
