using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class Common
    {
        public static IWebElement getElement(string locator)
        {
            return Driver.getDriver().FindElement(By.XPath(locator));        
        }

        public static void sendKeysToElement(string locator, string keys)
        { 
            getElement(locator).SendKeys(keys);    
        }

        public static void clickElement(string locator)
        {
            getElement(locator).Click();
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
    }
}
