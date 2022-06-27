using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.SeleniumEasy
{
    public class BasicFirsFormDemoPage
    {
        public static void closeAdvertisement()
        {
            string locator = "//*[@id='at-cv-lightbox-close']";
            Common.waitForElementToBeVisible(locator);
            Common.clickElement(locator);
        }

        public static void enterMessage(string message)
        {
            string locator = "//*[@id='user-message']";
            Common.sendKeysToElement(locator, message);
        }

        public static void clickShowMessageButton()
        {
            string locator = "//*[@id='get-input']/button";
            Common.clickElement(locator);
        }

        public static string readMessage()
        {
            string locator = "//*[@id='display']";
            return Common.getElementText(locator);
        }
    }
}