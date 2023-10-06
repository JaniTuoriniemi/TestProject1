using CalculatorSelenium.Specs.Drivers;
using CalculatorSelenium.Specs.PageObjects;
using System;
using TechTalk.SpecFlow;
using static System.Net.WebRequestMethods;
namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        public CalculatorPageObject _calculatorPageObject;

        public Feature1StepDefinitions(BrowserDriver browserDriver)

        {

            _calculatorPageObject = new CalculatorPageObject(browserDriver.Current);

        }
        //This is är test1.It tests the steps 1-4 in Test scenario 2.
        [Given(@"The browser is on the ta emot page being not logged in")]
        public void GivenTheBrowserIsOnTheTaEmotPageBeingNotLoggedIn()
        {
            _calculatorPageObject.GotoPage1();
        }

        [When(@"Ta emot is clicked and the browser is taken to the login page")]
        public void WhenTaEmotIsClickedAndTheBrowserIsTakenToTheLoginPage()
        {
            _calculatorPageObject.ClickTa_emot();
        }

        [Then(@"The browser is logged in and taken to either of two pages depending if the book is already registered or not")]
        public void ThenTheBrowserIsLoggedInAndTakenToEitherOfTwoPagesDependingIfTheBookIsAlreadyRegisteredOrNot()
        {
            string word = "Koopa11Kiipa";

            string number = "730622401";

            _calculatorPageObject.StatePhoneNumber(number);

            _calculatorPageObject.StatePassWord(word);

            _calculatorPageObject.ClickLoginButton();

            if (_calculatorPageObject.CurrentURL() == "https://reink.se/book/leave-book?BookId=6c6d0395-c667-4bf9-b5f5-0d13ca706b27")

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
        //This is är test2.It tests the steps 6-7b-9 in Test scenario 2.
        [Given(@"The browser is on the Ta emot page")]
        public void GivenTheBrowserIsOnTheTaEmotPage()
        {
            string bookID = "EE";
            _calculatorPageObject.GotoPage2(bookID);

            _calculatorPageObject.ClickLämmnaPåAddressButton();
        }

        [When(@"jag ska lämna boken på en addres is cklicked and the browser is logged in")]
        public void WhenJagSkaLamnaBokenPaEnAddresIsCklickedAndTheBrowserIsLoggedIn()
        {
            string word = "Koopa11Kiipa";

            string number = "730622401";

            _calculatorPageObject.StatePhoneNumber(number);

            _calculatorPageObject.StatePassWord(word);

            _calculatorPageObject.ClickLoginButton();
        }

        [Then(@"The screen jag är klar is visible")]
        public void ThenTheScreenJagArKlarIsVisible()
        {
            string desired_page = "https://reink.se/book/leave-book-on-map?code=eebe74a8-56ce-4e10-a8a2-6e4f6ef6c8cd";

            string actualResult = _calculatorPageObject.CurrentURL();

            actualResult.Should().Be(desired_page);
        }
        //This is är test3.It tests the steps 6-10 in Test scenario 2.
        [Given(@"Nästa is clicked and the browser is taken to login screen")]
        public void GivenNastaIsClickedAndTheBrowserIsTakenToLoginScreen()
        {
            string bookID = "EE";
            _calculatorPageObject.GotoPage2(bookID);

            _calculatorPageObject.ClickNästaButtonLämna();
        }

        [When(@"The browser is logged in")]
        public void WhenTheBrowserIsLoggedIn()
        {
            string word = "Koopa11Kiipa";

            string number = "730622401";

            _calculatorPageObject.StatePhoneNumber(number);

            _calculatorPageObject.StatePassWord(word);

            _calculatorPageObject.ClickLoginButton();
        }

        [Then(@"The betala screen is visible")]
        public void ThenTheBetalaScreenIsVisible()
        {
            string desired_page = "https://reink.se/account/payment-swish?BookId=6c6d0395-c667-4bf9-b5f5-0d13ca706b27";

            string actualResult = _calculatorPageObject.CurrentURL();

            actualResult.Should().Contain(desired_page);
        }
        //This is är test4.It tests the steps 9-7b-10 in Test scenario 2.
        [Given(@"The browser is on the betala screen")]
        public void GivenTheBrowserIsOnTheBetalaScreen()
        {
            _calculatorPageObject.GotoPage3();

            string word = "Koopa11Kiipa";

            string number = "730622401";

            _calculatorPageObject.StatePhoneNumber(number);

            _calculatorPageObject.StatePassWord(word);

            _calculatorPageObject.ClickLoginButton();
        }

        [Then(@"The price is set to (.*) Kr and Betala is clicked\.")]
        public void ThenThePriceIsSetToKrAndBetalaIsClicked_(int p0)
        {
            string phone = "+46730622401";

            _calculatorPageObject.MoveSlider();

            _calculatorPageObject.StateSwishnumber(phone);

            _calculatorPageObject.ClickBetalaSwish();
        }

        [Then(@"A Swish checkout page is visible")]
        public void ThenASwishCheckoutPageIsVisible()
        {
            string desired_page = "https://reink.se/account/paymentswishapp";

            string actualResult = _calculatorPageObject.CurrentURL();

            actualResult.Should().Be(desired_page);
        }
    }
}
