using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationWebBootcamp.src.code.control;

namespace AutomationWebBootcamp.src.code.page
{
    public class LoginSection
    {
        public TextBox emailTextBox = new TextBox(By.XPath("//div/input[@id='element-0']"));
        public TextBox pwdTextBox = new TextBox(By.XPath("//div/input[@id='element-3']"));
        public Button loginButton = new Button(By.XPath("//button[@data-gtm-id=\"start-email-login\"]"));

        public void Login(String user, String pwd)
        {
            emailTextBox.SetText(user);
            pwdTextBox.SetText(pwd);
            loginButton.Click();
        }
    }
}
