using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationWebBootcamp.src.code.control;

namespace AutomationWebBootcamp.src.code.page
{
    public class MainPage
    {
        public Button loginButton = new Button(By.XPath("//li/a[text() = 'Log in']"));
    }
}
