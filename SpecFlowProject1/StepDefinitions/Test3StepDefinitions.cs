using CalculatorSelenium.Specs.Drivers;
using CalculatorSelenium.Specs.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Test3StepDefinitions
    {
        public string filledSwishPaymentReference;
        public string password;
        public string phonenumber;
        // These are the parameters to be filled into the hidden test form
        public string amount;
        public string bookID;
        public string averagePrice;
        public string averagePricePlusExtra;
        public string paymentReference;
        public string bookQRcode;

        public CalculatorPageObject _calculatorPageObject;

        public Test3StepDefinitions(BrowserDriver browserDriver)
        {
            _calculatorPageObject = new CalculatorPageObject(browserDriver.Current);
            password = "Koopa11Kiipa";//User password
            phonenumber = "730622401";//User phone
            bookQRcode = "eebe74a8-56ce-4e10-a8a2-6e4f6ef6c8cd";
            amount = "1";
            bookID = "6c6d0395-c667-4bf9-b5f5-0d13ca706b27"; //The book QR code number  
            averagePrice = "1";
            averagePricePlusExtra = "1";
            paymentReference = "3AF9E317B9E54B5ABF481F85E8A96D45";//Probably should be the user GUID?
            filledSwishPaymentReference = "";

        }
            [Given(@"The Browser is directed to the login page and the user is logged in")]
            public void GivenTheBrowserIsDirectedToTheLoginPageAndTheUserIsLoggedIn()
            {
            _calculatorPageObject.GotoPage5();
            _calculatorPageObject.StatePhoneNumber(phonenumber);
            _calculatorPageObject.StatePassWord(password);
            _calculatorPageObject.ClickLoginButton(); 
            }

            [When(@"The browser is directed to the book registering page as if its QR code was scanned and the nästa button is clicked")]
            public void WhenTheBrowserIsDirectedToTheBookRegisteringPageAsIfItsQRCodeWasScannedAndTheNastaButtonIsClicked()
            {
            _calculatorPageObject.GotoPage6(bookQRcode);
            _calculatorPageObject.ClickTa_emot();
            }

            [Then(@"The browser should now show the boken är registrerad confirmation page")]
            public void ThenTheBrowserShouldNowShowTheBokenArRegistreradConfirmationPage()
            {
            _calculatorPageObject.GotoPage7();//For test purposes with non registrable books only.Line should be commented away. 
            bool result=_calculatorPageObject.VerifyBookregistered() ;
            int actualResult = 0;
            if (result) { actualResult = 1; }
            actualResult.Should().Be(1);
            }

            [Given(@"The browser moves to the page where it is directed to when the books QR code is scanned again and lämna boken på en adress is clicked")]
            public void GivenTheBrowserMovesToThePageWhereItIsDirectedToWhenTheBooksQRCodeIsScannedAgainAndLamnaBokenPaEnAdressIsClicked()
            {
            _calculatorPageObject.GotoPage8(bookID);
            _calculatorPageObject.ClickLämmnaPåAddressButton();
            _calculatorPageObject.StatePhoneNumber(phonenumber);
            _calculatorPageObject.StatePassWord(password);
            _calculatorPageObject.ClickLoginButton();
        }

            [When(@"When the browser is taken to the leave book on a adress page the nästa button is clicked")]
            public void WhenWhenTheBrowserIsTakenToTheLeaveBookOnAAdressPageTheNastaButtonIsClicked()
            {
            
            _calculatorPageObject.ClickNästaButtonLämna2();
            }
            [Then(@"The browser is taken to the payment page")]
            public void ThenTheBrowserIsTakenToThePaymentPage()
            {
            string actualResult = _calculatorPageObject.CurrentURL();
            string desired_page = "https://reink.se/account/payment-swish?BookId=" + bookID;
            actualResult.Should().Contain(desired_page);
            }

            [Given(@"The browser is on the payment page-")]
            public void GivenTheBrowserIsOnThePaymentPage_()
            {
                throw new PendingStepException();
            }

            [When(@"The payment test form is filled")]
            public void WhenThePaymentTestFormIsFilled()
            {
                throw new PendingStepException();
            }

            [Then(@"The test form is read on the Swish confirmation page")]
            public void ThenTheTestFormIsReadOnTheSwishConfirmationPage()
            {
                throw new PendingStepException();
            }
        }
    }

