using CalculatorSelenium.Specs.Drivers;
using CalculatorSelenium.Specs.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Test1StepDefinitions
    {
        public string startPage;
        public string password;
        public string phonenumber;
        public string bookID;
        public string bookQRcode;
        public CalculatorPageObject _calculatorPageObject;
        public Test1StepDefinitions(BrowserDriver browserDriver)

        { 
            _calculatorPageObject = new CalculatorPageObject(browserDriver.Current);
             startPage = _calculatorPageObject.GiveStart();
            password = "Koopa11Kiipa";//User password
            phonenumber = "123456789";//User phone
            bookQRcode = "eebe74a8-56ce-4e10-a8a2-6e4f6ef6c8cd";
            bookID = "6c6d0395-c667-4bf9-b5f5-0d13ca706b27"; //The book QR code number  
        }
        [Given(@"The user is on registrera din bok and clicks ta emot")]
        public void GivenTheUserIsOnRegistreraDinBokAndClicksTaEmot()
        {
            _calculatorPageObject.GotoPage6(bookQRcode);
            _calculatorPageObject.ClickTa_emot();
        }

        [When(@"The user is taken to the login page and clicks inget Konto\? Registrera dig")]
        public void WhenTheUserIsTakenToTheLoginPageAndClicksIngetKontoRegistreraDig()
        {
            _calculatorPageObject.ClickIngetKonto();
        }

        [Then(@"The user is taken to the bli medlem page")]
        public void ThenTheUserIsTakenToTheBliMedlemPage()
        {
            string actualResult = _calculatorPageObject.CurrentURL();
            string desired_page = $"{startPage}/account/register";
            actualResult.Should().Be(desired_page);
        }

        [Given(@"User is on the bli medlem page and states his phone number and clicks verifiera")]
        public void GivenUserIsOnTheBliMedlemPageAndStatesHisPhoneNumberAndClicksVerifiera()
        {
            _calculatorPageObject.StatePhoneNumber(phonenumber);
            _calculatorPageObject.ClickCheckbox();
            _calculatorPageObject.ClickVerifiera1();
        }

        [When(@"The user states the verification code and clicks verifiera")]
        public void WhenTheUserStatesTheVerificationCodeAndClicksVerifiera()
        {
            _calculatorPageObject.StateVerificationCode();
            _calculatorPageObject.ClickVerifiera2();
        }

        [Then(@"The user is take to skapa lösenord page")]
        public void ThenTheUserIsTakeToSkapaLosenordPage()
        {
            string actualResult = _calculatorPageObject.CurrentURL();
            string desired_page = $"{startPage}webpage";
            actualResult.Should().Be(desired_page);
        }

        [Given(@"The user is on the skapalösenord page and states his chosen password twice")]
        public void GivenTheUserIsOnTheSkapalosenordPageAndStatesHisChosenPasswordTwice()
        {
            _calculatorPageObject.CreatePassWord(password);
        }

        [When(@"User clicks spara")]
        public void WhenUserClicksSpara()
        {
            
            _calculatorPageObject.ClickSavepassword();
        }

        [Then(@"The user is again on the registrera din bok")]
        public void ThenTheUserIsAgainOnTheRegistreraDinBok()
        {
            string actualResult = _calculatorPageObject.CurrentURL();
            string desired_page = $"{startPage}webpage";
            actualResult.Should().Be(desired_page);
        }

        [Given(@"The user is on the registrera din bok and goes to min profil")]
        public void GivenTheUserIsOnTheRegistreraDinBokAndGoesToMinProfil()
        {
            throw new PendingStepException();
        }

        [When(@"The use clicks on ta bort mitt konto")]
        public void WhenTheUseClicksOnTaBortMittKonto()
        {
            throw new PendingStepException();
        }

        [Then(@"The user in now on the start page without being logged in")]
        public void ThenTheUserInNowOnTheStartPageWithoutBeingLoggedIn()
        {
            throw new PendingStepException();
        }
    }
}
