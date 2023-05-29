using AutomationWebBootcamp.src.code.page;

namespace AutomationWebBootcamp.src.code.test.todoistTests
{
    [TestClass]
    public class ProjectTestTodoist : TestBaseTodoist
    {
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftMenu leftMenu= new LeftMenu();

        [TestMethod]
        public void verifyCRUDTodoist() 
        { 
            mainPage.loginButton.Click();
            loginSection.Login("respinoza.test@gmail.com", "130391test!");

            string projectName = "REtest";
            leftMenu.addProjectButton.Click();
            leftMenu.nameProjectTextBox.SetText(projectName);
            leftMenu.addButton.Click();

            // add verificacion
            Assert.IsTrue(leftMenu.IsProjectNameDisplayed(projectName), "ERROR!The project was not created");

            string editedProjectName = "REtestUpdated1234";
            leftMenu.ClickProject(projectName);
            leftMenu.actionButton.Click();
            leftMenu.editProjectButton.Click();         
            leftMenu.projectNameEditTextBox.SetText(editedProjectName);
            leftMenu.saveButton.Click();
            Thread.Sleep(1000);
            
            // add verificacion
            Assert.IsTrue(leftMenu.IsProjectNameDisplayed(editedProjectName), "ERROR!The project was not edited");

            leftMenu.ClickProject("REtestUpdated1234");
            leftMenu.actionButton.Click();
            leftMenu.deleteProjectButoon.Click();
            leftMenu.deleteButton.Click();
            Assert.IsFalse(leftMenu.IsProjectNameDisplayed(editedProjectName), "ERROR!The project was not deleted");
        }
    }
}
