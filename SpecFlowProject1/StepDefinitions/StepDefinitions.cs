using CalculatorSelenium.Specs.Drivers;
using CalculatorSelenium.Specs.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class StepDefinitions
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
            public StepDefinitions(BrowserDriverMozilla browserDriverMozilla)
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
            [Given(@"a\)The QR code is scanned and the browser is taken to ta emot page:")]
            public void GivenATheQRCodeIsScannedAndTheBrowserIsTakenToTaEmotPage()
            {
                _calculatorPageObject.GotoPage1();
            }

            [When(@"b\)Ta emot is clicked:")]
            public void WhenBTaEmotIsClicked()
            {
                _calculatorPageObject.ClickTa_emot();
            }

            [Then(@"c\)The browser is logged in:")]
            public void ThenCTheBrowserIsLoggedIn()
            {
                _calculatorPageObject.StatePhoneNumber(phonenumber);
                _calculatorPageObject.StatePassWord(password);
                _calculatorPageObject.ClickLoginButton();
                if (_calculatorPageObject.CurrentURL() == $"{startPage}/book/leave-book?BookId=" + bookID)
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

            [Given(@"a\)The browser return to ta emot page:")]
            public void GivenATheBrowserReturnToTaEmotPage()
            {
                if (_calculatorPageObject.CurrentURL() != $"{startPage}/book/register-qr?QrCode=" + bookQRcode)
                { _calculatorPageObject.GotoPage6(bookQRcode); }
            }

            [When(@"b\)ta emot"" clicked again:")]
            public void WhenBTaEmotClickedAgain()
            {
                _calculatorPageObject.GotoPage6(bookQRcode);
                _calculatorPageObject.ClickTa_emot();
            }

            [Then(@"c\)It should now read bok registrerad:")]
            public void ThenCItShouldNowReadBokRegistrerad()
            {
                _calculatorPageObject.GotoPage7();//For test purposes with non registrable books only.Line should be commented away. 
                bool result = _calculatorPageObject.VerifyBookregistered();
                int actualResult = 0;
                if (result) { actualResult = 1; }
                actualResult.Should().Be(1);
            }

            [Given(@"a\)The browser is logged out:")]
            public void GivenATheBrowserIsLoggedOut()
            {
                _calculatorPageObject.ClickMittKonto();
                _calculatorPageObject.ClickLogoutElement();
            }

            [When(@"b\)The QR koden is scanned:")]
            public void WhenBTheQRKodenIsScanned()
            {
                _calculatorPageObject.GotoPage6(bookQRcode);
            }

            [Then(@"c\)It must now read jag är klar:")]
            public void ThenCItMustNowReadJagArKlar()
            {
                string desired_page2 = $"{startPage}/book/book-registered";
                string actualResult2 = _calculatorPageObject.CurrentURL();
                actualResult2.Should().Be(desired_page2);
            }

            [Given(@"a\)The browser is now on the page jag är klar:")]
            public void GivenATheBrowserIsNowOnThePageJagArKlar()
            {
                _calculatorPageObject.GotoPage2(bookID);
            }

            [When(@"b\)click nästa and login:")]
            public void WhenBClickNastaAndLogin()
            { 
                _calculatorPageObject.ClickNästaButton();
                _calculatorPageObject.StatePhoneNumber(phonenumber);
                _calculatorPageObject.StatePassWord(password);
                _calculatorPageObject.ClickLoginButton();
            }

            [Then(@"c\)The browser is now on the page betala:")]
            public void ThenCTheBrowserIsNowOnThePageBetala()
            {
                string desired_page = $"{startPage}/account/payment-swish?BookId="+bookID;
                string actualResult = _calculatorPageObject.CurrentURL();
                actualResult.Should().Contain(desired_page);
            }

            [Given(@"a\)The browser goes to the the swish payment page")]
            public void GivenATheBrowserGoesToTheTheSwishPaymentPage()
            {      if ($"{startPage}/account/payment-swish?BookId=" + bookID != _calculatorPageObject.CurrentURL())
                { _calculatorPageObject.GotoPage4(bookQRcode); }
                //_calculatorPageObject.StatePhoneNumber(phonenumber);
                //_calculatorPageObject.StatePassWord(password);
                //_calculatorPageObject.ClickLoginButton();
            }

            [When(@"b\)The test form is filled")]
            public void WhenBTheTestFormIsFilled()
            {
                _calculatorPageObject.MoveSlider();// Moves the priceslider to 1 kr

                //The hidden form is filled in

                _calculatorPageObject.StateSwishAmount(amount);

                _calculatorPageObject.StateSwishBookID(bookID);

                //_calculatorPageObject.StateSwishAveragePrice(averagePrice);

                //_calculatorPageObject.StateSwishAveragePricePlusExtra(averagePricePlusExtra);

                //Uncomment the line below if you want to also set the paymentreference number"

                // _calculatorPageObject.StateSwishPaymentReference(paymentReference);

                // Gets the prefilled or user stated payment reference number

                // filledSwishPaymentReference= _calculatorPageObject.GetValueSwishPaymentReference();

                //The phone number is filled in (Altough is hould already be autofilled) an the "Betala" is clicked.

                _calculatorPageObject.StateSwishnumber("+46" + phonenumber);

                _calculatorPageObject.ClickBetalaSwish();
            }

            [Then(@"c\)The test form is read on the swish confirmation page")]
            public void ThenCTheTestFormIsReadOnTheSwishConfirmationPage()
            {


                // The values in the hidden form on the payment confirmation page are verified

                // string testamount= _calculatorPageObject.GetValueSwishTestAmount();

                string teststatus = _calculatorPageObject.GetValueSwishTestStatus();

                string testcode = _calculatorPageObject.GetValueSwishTestCode();

                string testticket = _calculatorPageObject.GetValueSwishTestTicket();

                _calculatorPageObject.StateSwishTestAmount(amount);

                _calculatorPageObject.ClickAvslutaButton();

                string pagesource = _calculatorPageObject.GetSource();

                dynamic jsonPage = _calculatorPageObject.ExtractJsonObject(pagesource);

                int controlnumber = 0;

                if (jsonPage.amount == amount)

                { controlnumber = controlnumber + 1; }

                if (jsonPage.status == teststatus)

                { controlnumber = controlnumber + 1; }

                //if (jsonPage.payeePaymentReference == "61a7754f65f64c5c9b13a06dbb8980b7" ) 

                //{ controlnumber = controlnumber + 1; }

                //if (jsonPage.id == "61a7754f65f64c5c9b13a06dbb8980b7") 

                //{ controlnumber = controlnumber + 1; }

                int actualResult = controlnumber;

                actualResult.Should().Be(2);



                //{ controlnumber=controlnumber+1; }

                //int controlnumber = 0;

                //if (testamount == "4")

                //{ controlnumber=controlnumber+1; }

                // if (teststatus == "PAID")

                //{ controlnumber = controlnumber + 1; }

                //if (testcode == "enter code")

                // { controlnumber = controlnumber + 1; }

                //if (testticket == filledSwishPaymentReference.ToLower() )

                //{ controlnumber = controlnumber + 1; }

                //int actualResult = controlnumber;

                //actualResult.Should().Be(4);//If the hidden test form is filled in as expected the control sum should be 4.

                //  "203e782c967d4350a21a4d3e5538e469"

                // "3af9e317b9e54b5abf481f85e8a96d45"

                //457643B8C6E044049B4C73F3CA303F68

                // 457643b8c6e044049b4c73f3ca303f68
            }

            [Given(@"a\)The browser is again on the page jag är klar:")]
            public void GivenATheBrowserIsAgainOnThePageJagArKlar()
            {
                _calculatorPageObject.GotoPage2(bookID);
                _calculatorPageObject.ClickLämmnaPåAddressButton();
            }

            [When(@"b\)Click lämna boken på en addres and login:")]
            public void WhenBClickLamnaBokenPaEnAddresAndLogin()
            {
                _calculatorPageObject.StatePhoneNumber(phonenumber);
                _calculatorPageObject.StatePassWord(password);
                _calculatorPageObject.ClickLoginButton();
            }

            [Then(@"c\)The jag är klar page with adress should be visible:")]
            public void ThenCTheJagArKlarPageWithAdressShouldBeVisible()
            {
                string desired_page = $"{startPage}/book/leave-book-on-map?code="+bookQRcode; 
                string actualResult = _calculatorPageObject.CurrentURL();
                actualResult.Should().Be(desired_page);
                _calculatorPageObject.ClickNästaButtonLämna2();
            }

            [Given(@"a\) The nästaabutton is clicked and the browser is taken to the payment page where the slider is moved and phone number stated")]
            public void GivenATheNastaabuttonIsClickedAndTheBrowserIsTakenToThePaymentPageWhereTheSliderIsMovedAndPhoneNumberStated()
            {
                if ($"{startPage}/account/payment-swish?BookId=" + bookID != _calculatorPageObject.CurrentURL())
                { _calculatorPageObject.GotoPage4(bookQRcode); }
               
            }

            [When(@"b\)The test form is filled and avsluta is clicked")]
            public void WhenBTheTestFormIsFilledAndAvslutaIsClicked()
            {
                _calculatorPageObject.MoveSlider();// Moves the priceslider to 1 kr

                //The hidden form is filled in

                _calculatorPageObject.StateSwishAmount(amount);

                _calculatorPageObject.StateSwishBookID(bookID);

                //_calculatorPageObject.StateSwishAveragePrice(averagePrice);

                //_calculatorPageObject.StateSwishAveragePricePlusExtra(averagePricePlusExtra);

                //Uncomment the line below if you want to also set the paymentreference number"

                // _calculatorPageObject.StateSwishPaymentReference(paymentReference);

                // Gets the prefilled or user stated payment reference number

                // filledSwishPaymentReference= _calculatorPageObject.GetValueSwishPaymentReference();

                //The phone number is filled in (Altough is hould already be autofilled) an the "Betala" is clicked.

                _calculatorPageObject.StateSwishnumber("+46" + phonenumber);

                _calculatorPageObject.ClickBetalaSwish();
            }

            [Then(@"c\) The hidden test form is read on the swish confirmation page")]
            public void ThenCTheHiddenTestFormIsReadOnTheSwishConfirmationPage()
            {
                // The values in the hidden form on the payment confirmation page are verified

                // string testamount= _calculatorPageObject.GetValueSwishTestAmount();

                string teststatus = _calculatorPageObject.GetValueSwishTestStatus();

                string testcode = _calculatorPageObject.GetValueSwishTestCode();

                string testticket = _calculatorPageObject.GetValueSwishTestTicket();

                _calculatorPageObject.StateSwishTestAmount(amount);

                _calculatorPageObject.ClickAvslutaButton();

                string pagesource = _calculatorPageObject.GetSource();

                dynamic jsonPage = _calculatorPageObject.ExtractJsonObject(pagesource);

                int controlnumber = 0;

                if (jsonPage.amount == amount)

                { controlnumber = controlnumber + 1; }

                if (jsonPage.status == teststatus)

                { controlnumber = controlnumber + 1; }

                //if (jsonPage.payeePaymentReference == "61a7754f65f64c5c9b13a06dbb8980b7" ) 

                //{ controlnumber = controlnumber + 1; }

                //if (jsonPage.id == "61a7754f65f64c5c9b13a06dbb8980b7") 

                //{ controlnumber = controlnumber + 1; }

                int actualResult = controlnumber;

                actualResult.Should().Be(2);



                //{ controlnumber=controlnumber+1; }

                //int controlnumber = 0;

                //if (testamount == "4")

                //{ controlnumber=controlnumber+1; }

                // if (teststatus == "PAID")

                //{ controlnumber = controlnumber + 1; }

                //if (testcode == "enter code")

                // { controlnumber = controlnumber + 1; }

                //if (testticket == filledSwishPaymentReference.ToLower() )

                //{ controlnumber = controlnumber + 1; }

                //int actualResult = controlnumber;

                //actualResult.Should().Be(4);//If the hidden test form is filled in as expected the control sum should be 4.

                //  "203e782c967d4350a21a4d3e5538e469"

                // "3af9e317b9e54b5abf481f85e8a96d45"

                //457643B8C6E044049B4C73F3CA303F68

                // 457643b8c6e044049b4c73f3ca303f68
            }
        }
    }


