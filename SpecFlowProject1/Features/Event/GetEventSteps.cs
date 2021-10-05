using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Features.Event
{
    [Binding]
    [Scope(Feature = "GetEvent")]
    public class GetEventSteps
    {
        [Given(@"use the http client")]
        public void GivenUseTheHttpClient()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"get a event")]
        public void WhenGetAEvent()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"use the event is id")]
        public void ThenUseTheEventIsId()
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
