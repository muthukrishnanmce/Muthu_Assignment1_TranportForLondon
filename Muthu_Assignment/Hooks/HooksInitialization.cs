//using Muthu_Assignment.Drivers;
//using System.Linq.Expressions;
//using TechTalk.SpecFlow;

//namespace Muthu_Assignment.Hooks
//{
//    [Binding]
//    public  class HooksInitialization
//    {
//        private readonly ScenarioContext _scenarioContext;


//        public HooksInitialization(ScenarioContext scenarioContext)
//        {
//            _scenarioContext = scenarioContext;
//        }

//        [BeforeScenario]
//        public void BeforeScenario()
//        {
//            SeleniumDriver seleniumDriver = new SeleniumDriver(_scenarioContext);
//            _scenarioContext.Set(seleniumDriver, "SeleniumDriver");
            
          
//        }
              

//        [AfterScenario]
//        public void AfterScenario()
//        {
            
//        }
//    }
//}