using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationWebBootcamp.src.code.control;

namespace AutomationWebBootcamp.src.code.page
{
    public class MenuSection
    {
        public Button accountButton = new Button(By.Id(":r2:"));
        public Button logoutButton = new Button(By.Id(":rh:"));
    }
}
