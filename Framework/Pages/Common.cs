using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Framework.Pages
{
    public class Common
    {
        public static IWebElement getElement(string locator)
        {
            return Driver.getDriver().FindElement(By.XPath(locator));        
        }

        public static void alertAccept()
        {
            Driver.getDriver().SwitchTo().Alert().Accept();
        }

        public static void alertCancel()
        {
            Driver.getDriver().SwitchTo().Alert().Dismiss();
        }

        public static void sendKeysToElement(string locator, string keys)
        { 
            getElement(locator).SendKeys(keys);    
        }

        public static void clickElement(string locator)
        {
            getElement(locator).Click();
        }

        public static void performRightClick(string locator)
        {
            IWebElement element = getElement(locator);
            Actions actions = new Actions(Driver.getDriver());
            
            //actions.MoveToElement(element);
            actions.ContextClick(element);
            actions.Perform();
        }

        public static void performDoubleClick(string locator)
        {
            IWebElement element = getElement(locator);
            Actions actions = new Actions(Driver.getDriver());

            actions.DoubleClick(element).Perform();
        }

        public static string getElementText(string locator)
        {
            return getElement(locator).Text;
        }

        public static void waitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
            //IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("elementID")));

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static void waitForElementToBeCkilkable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
            //IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("elementID")));

            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }

        internal static void waitForElementAttributeToContainValue(string locator, string attributeName, string attributeValue)
        {
            new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10))
               .Until(d => d.FindElement(By.XPath(locator)).GetAttribute(attributeName).Contains(attributeValue));
        }

        public static void selectOptionByValue(string locator, string value)
        {
            IWebElement element = getElement(locator);
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
        }
    }
}
