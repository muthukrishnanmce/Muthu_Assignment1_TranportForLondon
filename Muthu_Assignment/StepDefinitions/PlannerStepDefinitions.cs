using CalculatorSelenium.Specs.Drivers;
using CalculatorSelenium.Specs.PageObjects;
using FluentAssertions;
using Gherkin.CucumberMessages.Types;
using Muthu_Assignment.Pages;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TechTalk.SpecFlow;

namespace CalculatorSelenium.Specs.Steps
{
    [Binding]
    public sealed class PlannerStepDefinitions
    {
        //Page Object for Calculator
        private readonly PlannerLoginPage _plannerLoginPageObject;
        private readonly JourneyResultsPage _journeyResultsPage;

        public PlannerStepDefinitions(BrowserDriver browserDriver)
        {
            _plannerLoginPageObject = new PlannerLoginPage(browserDriver.Current);
            _journeyResultsPage = new JourneyResultsPage(browserDriver.Current);
        }

       

        [Given(@"I launch TFL Planner home page")]
        public void GivenILaunchTFLPlannerHomePage()
        {
            _plannerLoginPageObject.launchPlanner();
        }


        [When(@"I enter source as ""([^""]*)"" and destination as ""([^""]*)""")]
        public void WhenIEnterSourceAsAndDestinationAs(string source, string dest)
        {
            _plannerLoginPageObject.SourceAndDestination(source, dest);
            _plannerLoginPageObject.planMyJourney();
        }

        [Then(@"I validate if the locations are ""([^""]*)""")]
        public void ThenIValidateIfTheLocationsAreValid(string compare)
        {
            if(compare.Equals("valid"))
            {
                Assert.True(_journeyResultsPage.InvalidPlace());
            }
            else
            {
                Assert.True(_journeyResultsPage.InvalidPlace());
            }
        }

        [Then(@"I validate if I am not able to plan journey")]
        public void ThenIValidateIfIAmNotAbleToPlanJourney()
        {
            _plannerLoginPageObject.planMyJourney();
            Assert.True(_plannerLoginPageObject.noInput());
        }

        [When(@"I update journey as Arriving")]
        public void WhenIUpdateJourneyAsArriving()
        {
            _journeyResultsPage.updateEditUpdateJourney();
        }


        [Then(@"I validate if the journey is updated")]
        public void ThenIValidateIfTheJourneyIsUpdated()
        {
            Assert.True(_journeyResultsPage.isArrivingUpdated());
        }


        [When(@"I navigate back to previous page")]
        public void WhenINavigateBackToPreviousPage()
        {
            _journeyResultsPage.goBack();
        }

        [When(@"I click on Recents")]
        public void WhenIClickOnRecents()
        {
            _plannerLoginPageObject.viewRecents();
        }

        [Then(@"I valide if I can see recent journey for source ""([^""]*)"" and destination as ""([^""]*)""")]
        public void ThenIValideIfICanSeeRecentJourneyForSourceAndDestinationAs(string source, string destination)
        {
            Assert.True(_plannerLoginPageObject.checkIfRecentPresent(source, destination));

        }









    }
}