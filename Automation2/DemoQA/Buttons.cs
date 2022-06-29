using Framework;
using Framework.Pages.DemoQA;
using NUnit.Framework;
using Tests.BaseClasses;
using Tests.DemoQA;

namespace Automation2.DemoQA
{
    [Parallelizable(scope:ParallelScope.Children)]
    public class Buttons : BaseTest
    {
        [SetUp]

        public static void openPage()
        {
            ButtonsPage.open();
        }

        [Test]

        public static void leftClick()
        {
            string expectedMessage = "You have done a dynamic click";
            string actualMessage;
            ButtonsPage.leftClick();
            actualMessage = ButtonsPage.readMessageLeftClick();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]

        public static void rightClick()
        {
            string expectedMessage = "You have done a right click";
            string actualMessage;

            ButtonsPage.rightClick();
            actualMessage = ButtonsPage.readMessageRightClick();

            Assert.AreEqual(expectedMessage, actualMessage);

        }

        [Test]
        public static void doubleClick()
        {
            string expectedMessage = "You have done a double click";
            string actualMessage;

            ButtonsPage.doubleClick();
            actualMessage = ButtonsPage.readMessageDoubleClick();

            Assert.AreEqual(expectedMessage, actualMessage);

        }
    }
}
