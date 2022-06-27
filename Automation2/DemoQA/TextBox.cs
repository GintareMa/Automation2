using Framework;
using Framework.Pages.DemoQA;
using NUnit.Framework;

namespace Automation2.DemoQA
{
    public class TextBox
    {
        [SetUp]

        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demoqa.com/text-box");
        }

        [Test]

        public static void demoQaTextBox()
        {
            string expectedName = "Gintare";
            string expectedEmail = "blue@blue.com";

            TextBoxPage.enterFullname(expectedName);
            TextBoxPage.enterEmail(expectedEmail);
            TextBoxPage.clickSubmitButton();
            string actualName = TextBoxPage.getNameAfterSubmit();
            string actualEmail = TextBoxPage.getEmailAfterSubmit();

            Assert.IsTrue(actualName.Contains(expectedName));
            Assert.IsTrue(actualEmail.Contains(expectedEmail));
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
