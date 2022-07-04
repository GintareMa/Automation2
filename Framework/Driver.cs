using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;

namespace Framework
{
    public static class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>(); // driverio objektas

        public static void setDriver()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--start-maximized");
            //driver value yra <IWebDriver>
            options.AddArgument("--window-size=1600,1000");

            driver.Value = new ChromeDriver(options); // kreipiames i driver objekta virsuje, uzsetinam
            //driver.Value.Manage().Window.Maximize();
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);  // laukimas
        }

        public static void takeScreenshot()
        {
            string screenshotsPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            string screenshotName = $"{screenshotsPath}\\src-{Guid.NewGuid()}.png";
           
            Directory.CreateDirectory(screenshotsPath);
            Screenshot screenshot = ((ITakesScreenshot)Driver.getDriver()).GetScreenshot();
            screenshot.SaveAsFile(screenshotName, ScreenshotImageFormat.Png);
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
