using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Features.Event
{
    [Binding]
    [Scope(Feature = "PostEvent")]
    public class PostEventSteps
    {
        [Given(@"use the http client")]
        public void GivenUseTheHttpClient()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"post a event")]
        public void WhenPostAEvent()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"use a new event object")]
        public void ThenUseANewEventObject()
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
