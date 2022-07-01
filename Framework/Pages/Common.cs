using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.Pages
{
    public class Common
    {
        public static IWebElement getElement(string locator)
        {
            return Driver.getDriver().FindElement(By.XPath(locator));        
        }

        internal static List<string> getCurrentWindowHandles()
        {
            return Driver.getDriver().WindowHandles.ToList();
        }

        internal static string getCurrentWindowHandle()
        {
            return Driver.getDriver().CurrentWindowHandle;
        }

        public static List<IWebElement> getElements(string locator)
        {
            return Driver.getDriver().FindElements(By.XPath(locator)).ToList();
        }

        public static void alertAccept()
        {
            Driver.getDriver().SwitchTo().Alert().Accept();
        }

        internal static void switchToNewWindowFromParentWindowByHandle(string parentWindowHandle)
        {
            List<string> handles = getCurrentWindowHandles();
            foreach (string handle in handles) 
            {
                if (handle != parentWindowHandle) 
                {
                    Common.switchToWindowByHandle(handle);
                }
            }
        }

        public static void switchToWindowByHandle(string handle)
        {
            Driver.getDriver().SwitchTo().Window(handle);
        }

        public static void alertCancel()
        {
            Driver.getDriver().SwitchTo().Alert().Dismiss();
        }

        internal static void closeWindowByHandle(string handle)
        {
            Driver.getDriver().SwitchTo().Window(handle).Close();
        }

        public static void sendKeysToElement(string locator, string keys)
        { 
            getElement(locator).SendKeys(keys);    
        }

        public static void clickElement(string locator)
        {
            getElement(locator).Click();
        }

        internal static string getElementAttributeValue(string locator, string attributeName)
        {
            return getElement(locator).GetAttribute(attributeName);
        }

        internal static List<bool> getSelectedStatusForElements(string locator)
        {
            List<IWebElement> elementsList = getElements(locator);

            List<bool> sttausList = new List<bool>();
            foreach (IWebElement element in elementsList)
            {
                sttausList.Add(element.Selected);
            }
            return sttausList;
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

        public static void sendKeysToPopup(string name)
        {
            Driver.getDriver().SwitchTo().Alert().SendKeys(name);
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
