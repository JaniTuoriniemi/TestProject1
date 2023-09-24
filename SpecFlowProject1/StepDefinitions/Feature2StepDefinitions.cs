using CalculatorSelenium.Specs.Drivers;
using CalculatorSelenium.Specs.PageObjects;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;
using static System.Net.WebRequestMethods;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Feature2StepDefinitions
    {
        public  CalculatorPageObject _calculatorPageObject;

        public Feature2StepDefinitions(BrowserDriver browserDriver)
        {
            _calculatorPageObject = new CalculatorPageObject(browserDriver.Current);
        }

        [Given(@"Webbläsaren är oinloggad på ta emot sidan")]
        public void GivenWebblasarenArOinloggadPaTaEmotSidan()
        {
            _calculatorPageObject.GotoPage1();
        }



        [Given(@"Webbläsaren är oinloggad på ta emot sidan https://reink\.se/book/register-qr\?QrCode=eebe(.*)(.*)ce(.*)-a(.*)(.*)f(.*)ef(.*)cd")]
        public void GivenWebblasarenArOinloggadPaTaEmotSidanHttpsReink_SeBookRegister_QrQrCodeEebece_Afefcd()//(Decimal p0, int p1, Decimal p2, Decimal p3, Decimal p4, int p5, Decimal p6)
        {
            _calculatorPageObject.GotoPage1();
            
        }

        [When(@"Ta emot är klickad")]
        public void WhenTaEmotArKlickad()
        {
            _calculatorPageObject.ClickTa_emot();
        }

        [Then(@"webläsaren tas till login sidan")]
        public void ThenWeblasarenTasTillLoginSidan()
        {
            
            string word = "Koopa11Kiipa";
           string number = "730622401";
            _calculatorPageObject.StatePhoneNumber( number);

            _calculatorPageObject.StatePassWord( word);
            _calculatorPageObject.ClickLoginButton();
            string desired_page = "https://reink.se/book/register-qr?QrCode=eebe74a8-56ce-4e10-a8a2-6e4f6ef6c8cd";
            string actualResult = _calculatorPageObject.CurrentURL();
            actualResult.Should().Be(desired_page);
            
        }

        [Given(@"webläsaren är åter på ""([^""]*)""")]
        public void GivenWeblasarenArAterPa(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"""([^""]*)"" klickas igen")]
        public void WhenKlickasIgen(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"det ska nu stå ""([^""]*)""")]
        public void ThenDetSkaNuSta(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"webbläsaren är utloggad")]
        public void GivenWebblasarenArUtloggad()
        {
            throw new PendingStepException();
        }

        [When(@"QR koden skannas och webläsaren tas till https://reink\.se/book/register-qr\?QrCode=eebe(.*)(.*)ce(.*)-a(.*)(.*)f(.*)ef(.*)cd")]
        public void WhenQRKodenSkannasOchWeblasarenTasTillHttpsReink_SeBookRegister_QrQrCodeEebece_Afefcd(Decimal p0, int p1, Decimal p2, Decimal p3, Decimal p4, int p5, Decimal p6)
        {
            throw new PendingStepException();
        }

        [Then(@"det ska stå ""([^""]*)""")]
        public void ThenDetSkaSta(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"webläsaren står på ""([^""]*)"" sidan")]
        public void GivenWeblasarenStarPaSidan(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"klicka på nästa och logga in")]
        public void WhenKlickaPaNastaOchLoggaIn()
        {
            throw new PendingStepException();
        }

        [Then(@"""([^""]*)"" sidan ska visas")]
        public void ThenSidanSkaVisas(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"Nästa klickas")]
        public void WhenNastaKlickas()
        {
            throw new PendingStepException();
        }

        [Then(@"Betalasidan ska visas")]
        public void ThenBetalasidanSkaVisas()
        {
            throw new PendingStepException();
        }

        [Given(@"webläsaren är på ""([^""]*)"" sidan")]
        public void GivenWeblasarenArPaSidan(string betala)
        {
            throw new PendingStepException();
        }

        [When(@"sätt prist till (.*) kr")]
        public void WhenSattPristTillKr(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"Betalningen ska vara klar")]
        public void ThenBetalningenSkaVaraKlar()
        {
            throw new PendingStepException();
        }

        [Given(@"\[context]")]
        public void GivenContext()
        {
            throw new PendingStepException();
        }

        [When(@"\[action]")]
        public void WhenAction()
        {
            throw new PendingStepException();
        }

        [Then(@"\[outcome]")]
        public void ThenOutcome()
        {
            throw new PendingStepException();
        }
    }
}
