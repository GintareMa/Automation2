using Framework;
using Framework.Pages.SeleniumEasy;
using NUnit.Framework;

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

        [Test]
        [TestCase("5", "7", "12")]
        [TestCase("5", "-7", "-2")]
        [TestCase("5", "T", "NaN")]

        public static void twoInputFields(string inputA, string inputB, string expectedTotal)
        {
           // string inputA = "5";
           // string inputB = "7";
           // string expectedTotal = "12";
            string actualTotal;

            BasicFirsFormDemoPage.enterInputA(inputA);
            BasicFirsFormDemoPage.enterInputB(inputB);
            BasicFirsFormDemoPage.clickTotalButton();
            actualTotal = BasicFirsFormDemoPage.readTotal();
            Assert.AreEqual(expectedTotal, actualTotal);
        }
        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
