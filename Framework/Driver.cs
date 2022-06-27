using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Framework
{
    public class Driver
    {
        private static IWebDriver driver; // driverio objektas

        public static void setDriver()
        {
            driver = new ChromeDriver(); // kreipiames i driver objekta virsuje, uzsetinam
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);  // laukimas
        }

        public static IWebDriver getDriver() 
        { 
            return driver; // grazinam
        }

        public static void open(string url) 
        { 
            driver.Url = url;
        }

        public static void closeDriver() // kreipiames i driver objekta isjungti
        { 
            driver.Quit();
        }

    }
}
