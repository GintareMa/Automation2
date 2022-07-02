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
            string actualMessage;
            BasicCheckBoxDemoPage.clickSingleCheckbox();
            actualMessage = BasicCheckBoxDemoPage.readMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public static void multipleCheckBox()
        {
            string expectedButtonCheckedText = "Uncheck All";
            string expectedButtonUncheckedText = "Check All";
            string actualButtonText;

            // Click button and check button text
            BasicCheckBoxDemoPage.clickMultiCheckboxButton();
            actualButtonText = BasicCheckBoxDemoPage.readButtonText();
            Assert.AreEqual(expectedButtonCheckedText, actualButtonText);

            // Check status of all checkboxes
            bool actualStatus = BasicCheckBoxDemoPage.checkIfAllCheckboxesAreSelected();
            Assert.AreEqual(true, actualStatus);

            // Click button and check button text
            BasicCheckBoxDemoPage.clickMultiCheckboxButton();
            actualButtonText = BasicCheckBoxDemoPage.readButtonText();
            Assert.AreEqual(expectedButtonUncheckedText, actualButtonText);

            // Check status of all checkboxes
            actualStatus = BasicCheckBoxDemoPage.checkIfAllCheckboxesAreNotSelected();
            Assert.AreEqual(true, actualStatus);

        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}

