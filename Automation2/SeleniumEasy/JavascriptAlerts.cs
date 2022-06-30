using Framework;
using Framework.Pages.SeleniumEasy;
using NUnit.Framework;

namespace Automation2.SeleniumEasy
{
    public class JavascriptAlerts
    {

        [SetUp]

        public static void openPage()
        {
            Driver.setDriver();
            Driver.open("https://demo.seleniumeasy.com/javascript-alert-box-demo.html");
        }


        [Test]
        public static void acceptAlertBox()
        {
            JavascriptAlertsPage.clickButtonToOpenAlertBox();
            JavascriptAlertsPage.clickOkInAlertBox();
        }

        [Test]
        public static void acceptConfirmBox()
        {
            string expectedMessage = "You pressed OK!";
            string actualMessage;

            JavascriptAlertsPage.clickButtonToDisplayBox();
            JavascriptAlertsPage.clickOkInAlertBox();
            actualMessage = JavascriptAlertsPage.readMessage();

            Assert.IsTrue(actualMessage.Contains(expectedMessage), 
                $"Expectted message: '{expectedMessage}' to contain actual message: '{actualMessage}'");
        }

        [Test]
        public static void declineConfirmBox()
        {
            string expectedMessage = "You pressed Cancel!";
            string actualMessage;

            JavascriptAlertsPage.clickButtonToDisplayBox();
            JavascriptAlertsPage.clickCancelInAlertBox();
            actualMessage = JavascriptAlertsPage.readMessage();

            Assert.AreEqual(expectedMessage, actualMessage);

        }

        [Test]
        public static void acceptEnteredMessageInPromtBox() 
        {
            string expectedMessage = "Gintare";
            string actualMessage;

            JavascriptAlertsPage.clickButtonToDisplayPromtBox();
            JavascriptAlertsPage.enterNameInPromtBox(expectedMessage);
            JavascriptAlertsPage.clickOkInAlertBox();
            
            actualMessage = JavascriptAlertsPage.readEnteredMessage();

            Assert.IsTrue(actualMessage.Contains(expectedMessage)); 
        }

        [TearDown]
        public static void close()
        {
           Driver.closeDriver();
        }
    }
}
