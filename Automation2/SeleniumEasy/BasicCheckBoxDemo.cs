using Framework;
using Framework.Pages.SeleniumEasy;
using NUnit.Framework;

namespace Automation2.SeleniumEasy
{
    public class BasicCheckBoxDemo
    {
        [SetUp]

        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }

        [Test]

        public static void singleCheckBox()
        {
            string expectedMessage = "Success - Check box is checked";
            string actualMessage = "";
            BasicCheckBoxDemoPage.clickSingleCheckbox();
            actualMessage = BasicCheckBoxDemoPage.readMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }



        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}

