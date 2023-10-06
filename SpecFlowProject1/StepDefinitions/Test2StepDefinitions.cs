using CalculatorSelenium.Specs.Drivers;
using CalculatorSelenium.Specs.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Test2StepDefinitions
    {
        

        public string filledSwishPaymentReference;

        public string password;

        public string phonenumber;

        // These are the parameters to be filled into the hidden test form

        public string amount;
        public string startPage;
        public string bookID;
        public string averagePrice;
        public string averagePricePlusExtra;
        public string paymentReference;
        public string bookQRcode;

        public CalculatorPageObject _calculatorPageObject;

        // public Test3StepDefinitions(BrowserDriver browserDriver)
        public Test2StepDefinitions(BrowserDriverMozilla browserDriverMozilla)
        {

            //_calculatorPageObject = new CalculatorPageObject(browserDriver.Current);
            _calculatorPageObject = new CalculatorPageObject(browserDriverMozilla.Current);
            startPage = _calculatorPageObject.GiveStart();
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
        [Given(@"The QR code is scanned and the browser is taken to ta emot page:")]
        public void GivenTheQRCodeIsScannedAndTheBrowserIsTakenToTaEmotPage()
        {
            _calculatorPageObject.GotoPage1();
        }

        [When(@"Ta emot is clicked:")]
        public void WhenTaEmotIsClicked()
        {
            _calculatorPageObject.ClickTa_emot();
        }

        [Then(@"The browser is logged in:")]
        public void ThenTheBrowserIsLoggedIn()
        {
            _calculatorPageObject.StatePhoneNumber(phonenumber);
            _calculatorPageObject.StatePassWord(password);
            _calculatorPageObject.ClickLoginButton();
            if (_calculatorPageObject.CurrentURL() == $"{startPage}/book/leave-book?BookId="+bookID )
            {
                string desired_page = "https://reink.se/book/leave-book?BookId=6c6d0395-c667-4bf9-b5f5-0d13ca706b27";
                string actualResult = _calculatorPageObject.CurrentURL();
                actualResult.Should().Be(desired_page);
            }
            else
            {
                _calculatorPageObject.ClickTa_emot();
                string desired_page2 = "https://reink.se/book/book-registered";
                string actualResult2 = _calculatorPageObject.CurrentURL();
                actualResult2.Should().Be(desired_page2);
            }
        }

        [Given(@"The browser return to ta emot page:")]
        public void GivenTheBrowserReturnToTaEmotPage()
        { if (_calculatorPageObject.CurrentURL() != $"{startPage}/book/register-qr?QrCode="+bookQRcode)
            { _calculatorPageObject.GotoPage6(bookQRcode); }
        }

        [When(@"ta emot"" clicked again:")]
        public void WhenTaEmotClickedAgain()
        {
            _calculatorPageObject.GotoPage6(bookQRcode);
            _calculatorPageObject.ClickTa_emot();
        }

        [Then(@"It should now read bok registrerad:")]
        public void ThenItShouldNowReadBokRegistrerad()
        {
            _calculatorPageObject.GotoPage7();//For test purposes with non registrable books only.Line should be commented away. 
            bool result = _calculatorPageObject.VerifyBookregistered();
            int actualResult = 0;
            if (result) { actualResult = 1; }
            actualResult.Should().Be(1);
        }

        [Given(@"The browser is logged out:")]
        public void GivenTheBrowserIsLoggedOut()
        {
            _calculatorPageObject.ClickMittKonto();
            _calculatorPageObject.ClickLogoutElement(); 
        }

        [When(@"The QR koden is scanned:")]
        public void WhenTheQRKodenIsScanned()
        {
            _calculatorPageObject.GotoPage6(bookQRcode);
        }

        [Then(@"It must now read ""([^""]*)"":")]
        public void ThenItMustNowRead(string p0)
        {
            string desired_page2 = $"{startPage}/book/book-registered";
            string actualResult2 = _calculatorPageObject.CurrentURL();
            actualResult2.Should().Be(desired_page2);

        }

        [Given(@"The browser is now on the page ""([^""]*)"":")]
        public void GivenTheBrowserIsNowOnThePage(string p0)
        {
            _calculatorPageObject.GotoPage2(bookID) ;
        }

        [When(@"click nästa and login:")]
        public void WhenClickNastaAndLogin()
        {
            _calculatorPageObject.ClickNästaButton();
            _calculatorPageObject.StatePhoneNumber(phonenumber);
            _calculatorPageObject.StatePassWord(password);
            _calculatorPageObject.ClickLoginButton();
        }

        [Then(@"The browser is again on the page jag är klar:")]
        public void ThenTheBrowserIsAgainOnThePageJagArKlar()
        {
            throw new PendingStepException();
        }

        [Given(@"The browser is on the page jag är klar:")]
        public void GivenTheBrowserIsOnThePageJagArKlar()
        {
            throw new PendingStepException();
        }

        [When(@"Next is clicked:")]
        public void WhenNextIsClicked()
        {
            throw new PendingStepException();
        }

        [Then(@"The payment page is shown:")]
        public void ThenThePaymentPageIsShown()
        {
            throw new PendingStepException();
        }

        [Given(@"The browser is on the payment page where the slider is moved and phone number stated")]
        public void GivenTheBrowserIsOnThePaymentPageWhereTheSliderIsMovedAndPhoneNumberStated()
        {
            throw new PendingStepException();
        }

        [When(@"The hidden form is read on the confirmation page")]
        public void WhenTheHiddenFormIsReadOnTheConfirmationPage()
        {
            throw new PendingStepException();
        }

        [Then(@"Avsluta is klicked and the hidden form is read")]
        public void ThenAvslutaIsKlickedAndTheHiddenFormIsRead()
        {
            throw new PendingStepException();
        }

        [When(@"click lämna boken på en addres and login:")]
        public void WhenClickLamnaBokenPaEnAddresAndLogin()
        {
            throw new PendingStepException();
        }

        [Then(@"The jag är klar page with adress should be visible:")]
        public void ThenTheJagArKlarPageWithAdressShouldBeVisible()
        {
            throw new PendingStepException();
        }

        [Given(@"The näst abutton is clicked and the browser is taken to the payment page where the slider is moved and phone number stated")]
        public void GivenTheNastAbuttonIsClickedAndTheBrowserIsTakenToThePaymentPageWhereTheSliderIsMovedAndPhoneNumberStated()
        {
            throw new PendingStepException();
        }
    }
}
