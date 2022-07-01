using Framework;
using Framework.Pages.DemoQA;
using NUnit.Framework;

namespace Automation2.DemoQA
{
    public class BrowserWindow
    {
        [SetUp]

        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demoqa.com/browser-windows");
        }

        [Test]

        public static void tabs()
        {
            // Variables
            string expectedParentTabHeader = "Browser Windows";
            string expectedNewTabHeader = "This is a sample page";
            string actualParentTabHeader;
            string actualNewTabHeader;
            string parentWindowHandle;
            string newWindowHandle;
            int actualwindowsCount;

            // Get parent window handle (getCurrentWindowHandle)
            parentWindowHandle = BrowserWindowPage.getCurrentWindowHandle();
            actualwindowsCount = BrowserWindowPage.getWindowsCount();
            Assert.AreEqual(1, actualwindowsCount);

            // Open new tab
            BrowserWindowPage.clickNewTab();
           // BrowserWindowPage.clickNewWindow();
            actualwindowsCount = BrowserWindowPage.getWindowsCount();
            Assert.AreEqual(2, actualwindowsCount);

            // Switch to new tab
            BrowserWindowPage.switchToNewWindowFromParentWindowByHandle(parentWindowHandle);
            newWindowHandle = BrowserWindowPage.getCurrentWindowHandle();
            actualNewTabHeader = BrowserWindowPage.readNewTabHeader();
            Assert.AreEqual(expectedNewTabHeader, actualNewTabHeader);

            // Switch to parent
            BrowserWindowPage.switchToWindowByHandle(parentWindowHandle);
            actualParentTabHeader = BrowserWindowPage.readParentTabHeader();
            Assert.AreEqual(expectedParentTabHeader, actualParentTabHeader);

            // Close new tab, switch to parent
            BrowserWindowPage.closeWindowByHandle(newWindowHandle);
            BrowserWindowPage.switchToWindowByHandle(parentWindowHandle);
            actualwindowsCount = BrowserWindowPage.getWindowsCount();
            Assert.AreEqual(1, actualwindowsCount);

        }

        [TearDown]
        public static void close() 
        {
            Driver.closeDriver();
        }
    }
}
