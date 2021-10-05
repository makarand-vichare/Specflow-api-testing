using SpecFlowProject1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public sealed class TestRunLevelHook
    {

        [BeforeTestRun]
        public void BeforeTestRun()
        {
            TestConfig.LoadSettings();
            SpecFlowIoc.Initialize();
        }

        [AfterTestRun]
        public void AfterTestRun()
        {
            TestConfig.ClearSettings();
        }
    }
}
