using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CalculatorSelenium.Specs.PageObjects
{
    /// <summary>
    /// Calculator Page Object
    /// </summary>
    public class PlannerLoginPage
    {
        //The URL of the calculator to be opened in the browser
        private const string TFLPlannerURL = "https://tfl.gov.uk/plan-a-journey/";

        //The Selenium web driver to automate the browser
        private readonly IWebDriver _webDriver;

        //The default wait time in seconds for wait.Until
        public const int DefaultWaitInSeconds = 30;

        public PlannerLoginPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        //Finding elements by ID
       
        private IWebElement CookiesAcceptAll => _webDriver.FindElement(By.XPath("//button[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']"));
        private IWebElement CookiesAcceptDone => _webDriver.FindElement(By.XPath("//button[@class='cb-button']/strong[text()='Done']"));
        private IWebElement txtFrom => _webDriver.FindElement(By.Id("InputFrom"));
        private IWebElement txtTo => _webDriver.FindElement(By.Id("InputTo"));
        private IWebElement btnPlanMyJourney => _webDriver.FindElement(By.XPath("//input[@id='plan-journey-button']"));
        private IWebElement errInputFrom => _webDriver.FindElement(By.XPath("//span[@id='InputFrom-error']"));
        private IWebElement errInputTo => _webDriver.FindElement(By.XPath("//span[@id='InputTo-error']"));
        private IWebElement lnkRecents => _webDriver.FindElement(By.XPath("//a[normalize-space()='Recents']"));



        public void launchPlanner()
        {
            _webDriver.Navigate().GoToUrl(TFLPlannerURL);
            CookiesAcceptAll.Click();
            CookiesAcceptDone.Click();
        }

        public void SourceAndDestination(String source,String destination)
        {
            txtFrom.SendKeys(source);
            txtTo.SendKeys(destination);
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
           
            
        }

        public void planMyJourney()
        {
            btnPlanMyJourney.Click();
        }

        public bool noInput()
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return errInputFrom.Displayed && errInputTo.Displayed;
        }  

        public void viewRecents()
        {
            lnkRecents.Click();
        }

        public Boolean checkIfRecentPresent(string src,string dest)
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return _webDriver.FindElement(By.XPath("//a[contains(text(),'" + src + " to " + dest + "')]")).Displayed;
        }




    }
}