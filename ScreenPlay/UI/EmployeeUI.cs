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
        public static By Form = By.Id("formEmployee");
        public static By NameInput = By.XPath("//*[@id='formEmployee']/div[2]/div[1]/input");
        public static By EmailInput = By.XPath("//*[@id='formEmployee']/div[2]/div[2]/input");
        public static By AddressTextArea = By.Id("address");
        public static By PhoneInput = By.Id("phone");
        public static By AddButton = By.Id("addButton");
    }
}
