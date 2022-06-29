

namespace Framework.Pages.SeleniumEasy
{
    public class JavascriptAlertsPage
    {
        public static void clickButtonToOpenAlertBox()
        {
            string locator = "//*[@onclick='myAlertFunction()']";
            Common.clickElement(locator);
        }

        public static void clickOkInAlertBox()
        {
            Common.alertAccept();
        }
    }
}
