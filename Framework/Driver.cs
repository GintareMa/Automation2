using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Framework
{
    public class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>(); // driverio objektas

        public static void setDriver()
        {
            //driver value yra <IWebDriver>
            driver.Value = new ChromeDriver(); // kreipiames i driver objekta virsuje, uzsetinam
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);  // laukimas
        }

        public static IWebDriver getDriver() 
        { 
            return driver.Value; // grazinam
        }

        public static void open(string url) 
        { 
            driver.Value.Url = url;
        }

        public static void closeDriver() // kreipiames i driver objekta isjungti
        { 
            driver.Value.Quit();
        }

    }
}
