using AutomationWebBootcamp.src.code.control;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationWebBootcamp.src.code.page
{
    public class LeftMenu
    {
        public Button addProjectButton = new Button(By.XPath("//button[@aria-label= \"Add project\"]"));
        public TextBox nameProjectTextBox = new TextBox(By.Id("edit_project_modal_field_name"));
        public Button addButton = new Button(By.XPath("//button[@type=\"submit\"]"));

        public Button actionButton = new Button(By.XPath("(//button[@aria-label=\"More project actions\"])[last()]"));
        public Button editProjectButton = new Button(By.XPath("//div[contains(text(),'Edit project')]"));
        public TextBox projectNameEditTextBox = new TextBox(By.Id("edit_project_modal_field_name"));
        public Button saveButton = new Button(By.XPath("//button[@type=\"submit\"]"));

        public Button deleteProjectButoon = new Button(By.XPath("//div[contains(text(),'Delete project')]"));
        public Button deleteButton = new Button(By.XPath("//button[@type=\"submit\"]"));

        public bool IsProjectNameDisplayed(string project)
        {
            Label projectName = new Label(By.XPath("//a[@aria-label='" + project + ", 0 tasks']"));
            return projectName.IsControlDisplayed();
        }

        public bool ClickProject(string project)
        {
            Label projectName = new Label(By.XPath("//a[@aria-label='" + project + ", 0 tasks']"));
            return projectName.IsControlDisplayed();
        }
    }
}
