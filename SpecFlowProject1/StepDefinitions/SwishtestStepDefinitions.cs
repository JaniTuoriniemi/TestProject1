using CalculatorSelenium.Specs.Drivers;
using CalculatorSelenium.Specs.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class SwishtestStepDefinitions
    {

        public string password;
        public string phonenumber;
        
        // These are the parameters to be filled into the test form
        public string amount;
        public string bookID;
        public string averagePrice;
        public string averagePricePlusExtra;
        public string paymentReference;


        public CalculatorPageObject _calculatorPageObject;

        public SwishtestStepDefinitions(BrowserDriver browserDriver)

        {
            _calculatorPageObject = new CalculatorPageObject(browserDriver.Current);
            password = "Koopa11Kiipa";
            phonenumber = "730622401";
            amount = "1";
            bookID = "1";   
            averagePrice = "1";
            averagePricePlusExtra = "1";
            paymentReference = "1"; 
        }

        [Given(@"The browser is on the payment page")]
        public void GivenTheBrowserIsOnThePaymentPage()
        {
            _calculatorPageObject.GotoPage3();

            
            _calculatorPageObject.StatePhoneNumber(phonenumber);
            _calculatorPageObject.StatePassWord(password);
            _calculatorPageObject.ClickLoginButton();
        }

        [When(@"The test form is filled")]
        public void WhenTheTestFormIsFilled()
        {
            
            
            _calculatorPageObject.MoveSlider();// Moves the priceslider to 1 kr
            _calculatorPageObject.StateSwishAmount(amount);
            _calculatorPageObject.StateSwishBookID(bookID);
            _calculatorPageObject.StateSwishAveragePrice(averagePrice);
            _calculatorPageObject.StateSwishAveragePricePlusExtra(averagePricePlusExtra);
            _calculatorPageObject.StateSwishPaymentReference(paymentReference);
            _calculatorPageObject.StateSwishnumber(phonenumber);

            _calculatorPageObject.ClickBetalaSwish();
        }

        [Then(@"The test form is read on the swish confirmation page")]
        public void ThenTheTestFormIsReadOnTheSwishConfirmationPage()
        {
           string testamount= _calculatorPageObject.GetValueSwishTestAmount();
            string teststatus = _calculatorPageObject.GetValueSwishTestStatus();
            string testcode = _calculatorPageObject.GetValueSwishTestCode();
            string testticket = _calculatorPageObject.GetValueSwishTestTicket();
            int controlnumber = 0;
            if (testamount == "1")
            { controlnumber=controlnumber+1; }
            if (teststatus == "PAID")
            { controlnumber = controlnumber + 1; }
            if (testcode == "enter code")
            { controlnumber = controlnumber + 1; }
            if (testticket == "203e782c967d4350a21a4d3e5538e469")
            { controlnumber = controlnumber + 1; }
            int actualResult = controlnumber;
            actualResult.Should().Be(4);

        }
    }
}
