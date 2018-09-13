using OpenQA.Selenium;
using ScreenPlay.Actions;
using ScreenPlay.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenPlay.Tasks
{
    public class AddEmployee
    {
        public static void WithTheData(IWebDriver driver, string name, string email, string address, string phone)
        {
            Enter.Text(driver, EmployeeUI.NameInput, name);
            Enter.Text(driver, EmployeeUI.EmailInput, email);
            Enter.Text(driver, EmployeeUI.AddressTextArea, address);
            Enter.Text(driver, EmployeeUI.PhoneInput, phone);
            Click.On(driver, EmployeeUI.AddButton);
        }
    }
}
