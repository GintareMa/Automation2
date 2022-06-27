using Framework;
using Framework.Pages.SeleniumEasy;
using NUnit.Framework;

namespace Automation2.SeleniumEasy
{
    public class BasicSelectDropDownDemo
    {
        [SetUp]

        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demo.seleniumeasy.com/basic-select-dropdown-demo.html");
        }

        [Test]

        public static void singleSelect()
        {
            string expectedDay = "Tuesday";
            string aactualMessage;
            BasicSelectDropDownDemoPage.selectDayByValue(expectedDay);
            aactualMessage = BasicSelectDropDownDemoPage.readSelectedDay();
        
            Assert.IsTrue(aactualMessage.Contains(expectedDay), 
                $"Expected '{aactualMessage}' to contain value: '{expectedDay}'");    
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }

}
