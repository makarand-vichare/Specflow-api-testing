using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Features.Event
{
    [Binding]
    [Scope(Feature = "GetAllEvent")]
    public class GetAllEventSteps
    {
        [Given(@"the http client")]
        public void GivenTheHttpClient()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"get all events")]
        public void WhenGetAllEvents()
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
