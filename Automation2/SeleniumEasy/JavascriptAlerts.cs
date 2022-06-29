using Framework;
using Framework.Pages.SeleniumEasy;
using NUnit.Framework;
using Tests.BaseClasses;

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

            // Assert
        }
        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
