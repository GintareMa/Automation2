using Framework;
using Framework.Pages.Math;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Automation2.Math
{
    public class WidgetsMenu : BaseTest
    {
        [SetUp]
        public static void openPage()
        {
            Driver.open("https://mathscientific.com/lt/");

            //MathscientificPage.clickCloseSuscriberButtonWhichEnabledAfter15sec();
          
            
            //MathscientificPage.closeCokiesWithButtonOnlyEssentials();


        }

        [Test]
        public static void mouseHoverMainItem2()
        {

            string expectedItemInBansket = "Produktas sėkmingai įdėtas į krepšelį.";
           
            MathscientificPage.moveMouseOnMenu();
            MathscientificPage.closeCokiesWithButtonOnlyEssentials();
            MathscientificPage.moveMouseOnMaistoPapildai();
            MathscientificPage.choseFromMaistoPapildaiKolagenas();
            MathscientificPage.cklickOnTheProductKolagenasSuAvietemis();
            MathscientificPage.addProducteSuAvietemisToBasket();
            string actualItemInBansket = MathscientificPage.readMessageInBasket();
            Assert.AreEqual(expectedItemInBansket, actualItemInBansket);
            
        }

        [Test]
        public static void switchLanguagefromLtToEn()
        {
            string excpectedMessage = "Log In";
            MathscientificPage.hoverMouseOnLanguageSymbol();
            MathscientificPage.clickButtonToSwitchLanguageToInternational();
            string actualMessage = MathscientificPage.readLoginName();
            Assert.AreEqual(excpectedMessage, actualMessage);
        }

        [Test]

        public static void login()
        {
           // MathscientificPage.clickButtonPrisijunti();
        }
        
    }
}
