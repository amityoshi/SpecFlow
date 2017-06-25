using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;


namespace SpecFlowGettingStartedUT
{
    [Binding]
    public class TestOnlineCalculatorSteps
    {
        static IWebDriver driver;

        [Given(@"User opens ""(.*)"" and enters ""(.*)""")]
        public void GivenUserOpensAndEnters(string browser, string url)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
        }

        [Given(@"User enters (.*) and (.*)")]
        public void GivenUserEntersAnd(int firstVal, int secondVal)
        {
            driver.FindElement(By.Id("ID_nameField1")).SendKeys(firstVal.ToString());
            driver.FindElement(By.Id("ID_nameField2")).SendKeys(firstVal.ToString());
        }
        
        [Given(@"selects ""(.*)""")]
        public void GivenSelects(string opt)
        {
            if (opt.Equals("Add"))
            {
                driver.FindElement(By.Id("gwt-uid-1")).Click();
            }
            else if (opt.Equals("Mul"))
            {
                driver.FindElement(By.Id("gwt-uid-2")).Click();
            }
            else if (opt.Equals("Sub"))
            {
                driver.FindElement(By.Id("gwt-uid-3")).Click();
            }
        }
        
        [When(@"Click (.*) button")]
        public void WhenClickButton(string calculate)
        {
            driver.FindElement(By.Id("ID_calculator")).Click();
        }
        
        [Then(@"result should be (.*)")]
        public void ThenResultShouldBe(string result)
        {
            var actualResult = driver.FindElement(By.Id("ID_nameField3")).GetAttribute("value");
;
            Assert.AreEqual(result, actualResult);
        }
    }
}
