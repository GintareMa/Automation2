using Framework;
using Framework.Pages.DemoQA;
using NUnit.Framework;

namespace Tests.DemoQA
{
    public class RadioButton
    {
        [SetUp]

        public static void setup()
        {
            Driver.setDriver();
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

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
