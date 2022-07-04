using System;

namespace Framework.Pages.Math
{
    public class MathscientificPage
    {
        public static void moveMouseOnMenu()
        {
            string locator = "//*[@class='main-navigation__toggler-content']";
            Common.performHoverMouse(locator);
        }

        public static void clickCloseSuscriberButtonWhichEnabledAfter15sec()
        {
            string locator = "//*[@class='soundest-form-image-right-close ']";
            Common.waitForElementToBeCkilkable(locator);
            Common.clickElement(locator);
        }

        public static void closeCokiesWithButtonOnlyEssentials()
        {
            //string locator = "//*[@id='CybotCookiebotDialog' and contains(@style,'display: flex')]//*[@id='CybotCookiebotDialogBodyButtonDecline']";
            string locator = "//*[@id='CybotCookiebotDialog' and contains(@class,'CybotCookiebotDialogActive')]//*[@id='CybotCookiebotDialogBodyButtonDecline']";
            //*[@id='CybotCookiebotDialogBodyButtonDecline']";
            //*[@id='CybotCookiebotDialog' and contains(@style,'display: flex')]
            Common.waitForElementToBeVisible(locator);
            //Common.waitForElementToBeCkilkable(locator);
            Common.clickElement(locator);
        }

        public static void cklickOnTheProductKolagenasSuAvietemis()
        {
            string locator = "//*[text()='Grynas kolagenas su avietėmis']";
            Common.clickElement(locator);
        }

        public static string readMessageInBasket()
        {
            //string locator = "//*[@class='add-to-cart__wrapper']//span";
            //string locator = "//*[@class='added-to-cart-msg__text' and text()='Produktas sėkmingai įdėtas į krepšelį.']";
            string locator = "//*[text()='Produktas sėkmingai įdėtas į krepšelį.']";
            Common.waitForElementToBeVisible(locator);
            //*[contains(text(),'Produktas sėkmingai įdėtas į krepšelį')]";
            //*[@class='added-to-cart-msg__text']";
            //*[contains(text(),'Produktas sėkmingai įdėtas į krepšelį')]
            //span[@class='added-to-cart-msg__text']"

            return Common.getElementText(locator);
        }

        public static void addProducteSuAvietemisToBasket()
        {
            string locator = "//*[@data-name='Grynas kolagenas su avietėmis']";
            Common.clickElement(locator);
        }

        public static void choseFromMaistoPapildaiKolagenas()
        {
            string locator = "//*[@id='menu-item-62473']";
            Common.clickElement(locator);
        }

        public static void moveMouseOnMaistoPapildai()
        {
            string locator = "//*[@id='menu-item-62457']/a";
            Common.performHoverMouse(locator);
        }

        public static void hoverMouseOnLanguageSymbol()
        {
            string locator = "//*[@alt='lt']";
            Common.performHoverMouse(locator);
        }

        public static string readLoginName()
        {
            string locator = "//*[@class='navbar__user-area__login']";
            return Common.getElementText(locator);
        }

        public static void clickButtonToSwitchLanguageToInternational()
        {
            string locator = "//*[@class='lang-item']";
            Common.clickElement(locator);
        }
    }
}
