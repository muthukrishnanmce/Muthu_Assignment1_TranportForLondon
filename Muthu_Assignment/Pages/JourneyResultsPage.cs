using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Muthu_Assignment.Pages
{
    public class JourneyResultsPage
    {

        private readonly IWebDriver _webDriver;

        //The default wait time in seconds for wait.Until
        public const int DefaultWaitInSeconds = 30;

        public JourneyResultsPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private IWebElement lblInvalidLocation => _webDriver.FindElement(By.XPath("//span[contains(text(),'We found more than one location matching')]"));
        private IWebElement lnkEditJourney => _webDriver.FindElement(By.XPath("//span[normalize-space()='Edit journey']"));
        private IWebElement lblArriving => _webDriver.FindElement(By.XPath("//label[text()='Arriving']"));
        private IWebElement lblUpdateJourney => _webDriver.FindElement(By.XPath("//input[@id='plan-journey-button']"));
        private IWebElement lblArrivingAfterUpdate => _webDriver.FindElement(By.XPath("//span[normalize-space()='Arriving:']"));

        



        public Boolean InvalidPlace()
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return (lblInvalidLocation.Displayed);
        }

        public void EditJourney()
        {
            lnkEditJourney.Click();
        }

        public void updateEditUpdateJourney()
        {
            lnkEditJourney.Click();
            lblArriving.Click();
            lblUpdateJourney.Click();
        }

        public Boolean isArrivingUpdated()
        {
            return lblArrivingAfterUpdate.Displayed;
        }

        public void goBack()
        {
            _webDriver.Navigate().Back();
        }

    }
}
