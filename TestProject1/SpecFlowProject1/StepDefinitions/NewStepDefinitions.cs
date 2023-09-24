using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class NewStepDefinitions
    {
        [Given(@"there are numbers")]
        public void GivenThereAreNumbers()
        {
            throw new PendingStepException();
        }

        [When(@"numbers are subtracted")]
        public void WhenNumbersAreSubtracted()
        {
            throw new PendingStepException();
        }

        [Then(@"fan")]
        public void ThenFan()
        {
            throw new PendingStepException();
        }
    }
}
