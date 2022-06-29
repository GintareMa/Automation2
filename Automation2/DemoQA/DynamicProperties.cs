using Framework;
using Framework.Pages.DemoQA;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Automation2.DemoQA
{
    public class DynamicProperties : BaseTest
    {
        [SetUp]
        public static void openPage()
        {
            DynamicPropertiesPage.open();
        }

        [Test]

        public static void clickButtonWichEnabledsAfterDelay()
        {
            DynamicPropertiesPage.clickButtonWichEnabledAfter5seconds();
        }

        [Test]
        public static void clickButtonWhichChangesTextColorAfterDelay()
        {
            DynamicPropertiesPage.clickButtonThatChangesTextColor();
        }
    }
}