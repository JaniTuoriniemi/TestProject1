using CalculatorSelenium.Specs.Drivers;
using CalculatorSelenium.Specs.PageObjects;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;
using static System.Net.WebRequestMethods;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TestStepDefinitions
    {
        private readonly CalculatorPageObject _calculatorPageObject;

        public TestStepDefinitions(BrowserDriver browserDriver)
        {
            _calculatorPageObject = new CalculatorPageObject(browserDriver.Current);
        }
            [When(@"clicking the the link ""([^""]*)""")]
            public void WhenClickingTheTheLink(string login)
            {
                _calculatorPageObject.ClickLoginButton();
            }

            [Then(@"browser is redirecterd to https://reink\.se/auth/login")]
            public void ThenBrowserIsRedirecterdToHttpsReink_SeAuthLogin()
            {
            string url = "https://reink.se/auth/login";
            string actualResult = _calculatorPageObject.CurrentURL();
            actualResult.Should().Be(url.ToString());
            string word = "Koopa11Kiipa";
            string number = "730622401";
            _calculatorPageObject.StatePhoneNumber(number);

            _calculatorPageObject.StatePassWord(word);
            _calculatorPageObject.ClickLoginButton();



        }
    }
    }
