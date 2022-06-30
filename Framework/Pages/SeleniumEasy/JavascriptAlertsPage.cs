using System;

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

        public static void clickButtonToDisplayBox()
        {
            string locator = "//*[@onclick='myConfirmFunction()']";
            Common.clickElement(locator);
        }

        public static string readMessage()
        {
            string locator = "//*[@id='confirm-demo']";
            return Common.getElementText(locator);
        }

        public static void clickCancelInAlertBox()
        {
            Common.alertCancel();
        }

        public static void clickButtonToDisplayPromtBox()
        {
            string locator = "//*[@onclick='myPromptFunction()']";
            Common.clickElement(locator);
        }

        public static string readEnteredMessage()
        {
            string locator = "//*[@id='prompt-demo']";
            return Common.getElementText(locator);
        }

        public static void enterNameInPromtBox( string name)
        {
            Common.sendKeysToPopup(name);
        }
    }
}
