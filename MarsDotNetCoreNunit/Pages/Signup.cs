
using MarsDotNetCoreNunit.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsDotNetCoreNunit.Pages
{
    class SignUp
    {

        #region  Initialize Web Elements 
        //Finding the Join 
        private IWebElement Join => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/button"));

        //Identify FirstName Textbox
        private IWebElement FirstName => GlobalDefinitions.driver.FindElement(By.Name("firstName"));

        //Identify LastName Textbox
        private IWebElement LastName => GlobalDefinitions.driver.FindElement(By.Name("lastName"));

        //Identify Email Textbox
        private IWebElement Email => GlobalDefinitions.driver.FindElement(By.Name("email"));

        //Identify Password Textbox
        private IWebElement Password => GlobalDefinitions.driver.FindElement(By.Name("password"));
        //Identify Confirm Password Textbox

        private IWebElement ConfirmPassword => GlobalDefinitions.driver.FindElement(By.Name("confirmPassword"));

        //Identify Term and Conditions Checkbox
        private IWebElement Checkbox => GlobalDefinitions.driver.FindElement(By.Name("terms"));

        //Identify join button
        private IWebElement JoinBtn => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='submit-btn']"));
        #endregion

        public void Register()
        {
            GlobalDefinitions.ExcelOperations.PopulateInCollection(GlobalDefinitions.ReadJson(), "SignUp");
            // GlobalDefinitions.driver.Navigate().GoToUrl(GlobalDefinitions.ExcelOperations.ReadData(1,"url"));
            Thread.Sleep(1000);

            //Click on Join button
            Join.Click();
            Thread.Sleep(1000);

            //Enter FirstName
            FirstName.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "FirstName"));
            Thread.Sleep(1000);

            //Enter LastName;
            LastName.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "LastName"));
            Thread.Sleep(1000);

            //Enter Email
            Email.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "Email"));
            Thread.Sleep(1000);

            //Enter Password
            Password.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "Password"));

            //Enter Password again to confirm
            ConfirmPassword.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "Confirm"));
            Thread.Sleep(1000);

            //Click on Checkbox
            Checkbox.Click();
            Thread.Sleep(1000);

            //Click on join button to Sign Up
            JoinBtn.Click();
            Thread.Sleep(1000);


        }
    }
}
