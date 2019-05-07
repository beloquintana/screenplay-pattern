using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.UI
{
    public class EmployeeUI
    {
        public static By Form = By.Id("contentEmployee");
        public static By NameInput = By.Id("name");
        public static By EmailInput = By.Id("email");
        public static By AddressInput = By.Id("address");
        public static By PhoneInput = By.Id("phoneNumber");
        public static By City = By.XPath("//*[@id='gridEmployee']/tbody/tr/td/form/fieldset/div[3]/div/div/input");
        public static By State = By.Id("state");
        public static By PostCode = By.Id("postcode");
        public static By SuccessMessage = By.Id("success-alert");

        public static By AddButton = By.Id("addButton");
    }
}
