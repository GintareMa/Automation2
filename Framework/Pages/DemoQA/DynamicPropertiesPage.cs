using System;

namespace Framework.Pages.DemoQA
{
    public class DynamicPropertiesPage
    {
        public static void open()
        {
            Driver.open("https://demoqa.com/dynamic-properties");
        }

        public static void clickButtonWichEnabledAfter5seconds()
        {
            string locator = "//*[@id='enableAfter']";
            Common.waitForElementToBeCkilkable(locator);
            Common.clickElement(locator);
        }

        public static void clickButtonThatChangesTextColor()
        {
            string locator = "//*[@id='colorChange']";
            string attributeName = "class";
            string attributeValue = "text-danger";
            Common.waitForElementAttributeToContainValue(locator, attributeName, attributeValue);
            Common.clickElement(locator);
        }
    }
}
