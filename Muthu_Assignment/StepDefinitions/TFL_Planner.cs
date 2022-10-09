//using Muthu_Assignment.Drivers;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using TechTalk.SpecFlow;
//using Windows.Media.Core;

//namespace Muthu_Assignment.StepDefinitions
//{
//    [Binding]
//    public sealed class TFL_Planner
//    {
//        IWebDriver driver;
//        private readonly ScenarioContext _scenarioContext;

//        public TFL_Planner(ScenarioContext scenarioContext)
//        {
//            _scenarioContext = scenarioContext;
//        }

//        [Given(@"I launch TFL Planner")]
//        public void I_Launch_URL()
//        {
//            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
//            driver.Url = "https://tfl.gov.uk/plan-a-journey/";
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
//            driver.FindElement(By.XPath("//button[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']")).Click();
//            driver.FindElement(By.XPath("//button[@class='cb-button']/strong[text()='Done']")).Click();
            
//        }

//        [Then(@"I see the Planner Home Page")]
//        public void Then_I_See_The_Planner_Home_Page()
//        {
            
//            driver.FindElement(By.Id("InputFrom")).SendKeys("London");

//        }



//    }
//}
