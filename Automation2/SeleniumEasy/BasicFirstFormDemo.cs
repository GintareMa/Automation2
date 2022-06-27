using Framework;
using Framework.Pages.SeleniumEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation2.SeleniumEasy
{
    public class BasicFirstFormDemo
    {
        [SetUp]

        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demo.seleniumeasy.com/basic-first-form-demo.html");
            BasicFirsFormDemoPage.closeAdvertisement();
        }

        [Test]
        public static void singleImputField()
        {
            string expecedMessage = "Test";
            string actualMessage;

            BasicFirsFormDemoPage.enterMessage(expecedMessage);
            BasicFirsFormDemoPage.clickShowMessageButton();
            actualMessage = BasicFirsFormDemoPage.readMessage();

            Assert.AreEqual(expecedMessage, actualMessage);
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
