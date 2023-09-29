using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Test3StepDefinitions
    {
        [Given(@"The Browser is directed to the login page and the user is logged in")]
        public void GivenTheBrowserIsDirectedToTheLoginPageAndTheUserIsLoggedIn()
        {
            throw new PendingStepException();
        }

        [When(@"The browser is directed to the book registering page as if its QR code was scanned and the nästa button is clicked")]
        public void WhenTheBrowserIsDirectedToTheBookRegisteringPageAsIfItsQRCodeWasScannedAndTheNastaButtonIsClicked()
        {
            throw new PendingStepException();
        }

        [Then(@"The browser should now show the boken är registrerad confirmation page")]
        public void ThenTheBrowserShouldNowShowTheBokenArRegistreradConfirmationPage()
        {
            throw new PendingStepException();
        }

        [Given(@"The browser moves to the page where it is directed to when the books QR code is scanned again and lämna boken på en adress is clicked")]
        public void GivenTheBrowserMovesToThePageWhereItIsDirectedToWhenTheBooksQRCodeIsScannedAgainAndLamnaBokenPaEnAdressIsClicked()
        {
            throw new PendingStepException();
        }

        [When(@"When the browser is taken to the leave book on a adress page the nästa button is clicked")]
        public void WhenWhenTheBrowserIsTakenToTheLeaveBookOnAAdressPageTheNastaButtonIsClicked()
        {
            throw new PendingStepException();
        }

        [Then(@"The browser is taken to the payment page")]
        public void ThenTheBrowserIsTakenToThePaymentPage()
        {
            throw new PendingStepException();
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
