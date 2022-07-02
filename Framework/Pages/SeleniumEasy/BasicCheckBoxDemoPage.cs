using System;
using System.Collections.Generic;

namespace Framework.Pages.SeleniumEasy
{
    public class BasicCheckBoxDemoPage
    {
        public static void clickSingleCheckbox()
        {
            string locator = "//*[@id='isAgeSelected']";
            Common.clickElement(locator);
        }

        public static string readMessage()
        {
            string locator = "//*[@id='txtAge']";
            return Common.getElementText(locator);
        }

        public static void clickMultiCheckboxButton()
        {
            string locator = "//*[@id='check1']";
            Common.clickElement(locator);
        }

        public static string readButtonText()
        {
            string locator = "//*[@id='check1']";
            string attributeName = "value";
            return Common.getElementAttributeValue(locator, attributeName);
        }

        public static bool checkIfAllCheckboxesAreSelected()
        {
            string locator = "//*[@class='cb1-element']";
            List<bool> statusList = Common.getSelectedStatusForElements(locator);

            foreach (bool status in statusList)
            {
                if (status == false)
                { 
                    return false;
                }
            }

            return true;
        }

        public static bool checkIfAllCheckboxesAreNotSelected()
        {
            string locator = "//*[@class='cb1-element']";
            List<bool> statusList = Common.getSelectedStatusForElements(locator);

            foreach (bool status in statusList)
            {
                if (status == true)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
