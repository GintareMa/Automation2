using Framework;
using Framework.Pages.DemoQA;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Tests.DemoQA
{
    public class RadioButton : BaseTest
    {
        [SetUp]
        public static void openPage()
        {
            Driver.open("https://demoqa.com/radio-button");
        }

        [Test]

        public static void radioButton()
        {
            string expectedMessage = "Yes";

            RadioButtonPage.clickYesRadioButton();
            string actualMessage = RadioButtonPage.getMessage();

            Assert.IsTrue(actualMessage.Contains(expectedMessage));
        }
    }
}
