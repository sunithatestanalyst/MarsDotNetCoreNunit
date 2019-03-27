﻿using MarsDotNetCoreNunit.Global;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace MarsDotNetCoreNunit.Pages
{
    class SignIn
    {
        #region  Initialize Web Elements 
        //Finding the Sign button
        private IWebElement SignIntab => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));

        // Finding the Email Field
        private IWebElement Email => GlobalDefinitions.driver.FindElement(By.Name("email"));

        //Finding the Password Field
        private IWebElement Password => GlobalDefinitions.driver.FindElement(By.Name("password"));

        //Finding the Login Button
        private IWebElement LoginBtn => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class ='field']/button"));

        //Verification
        private IWebElement Test => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
        #endregion

        public void LoginSteps()
        {

            GlobalDefinitions.ExcelOperations.PopulateInCollection(GlobalDefinitions.ReadJson(), "SignIn"); //Populating second sheet of excel sheet

            string pathurl = GlobalDefinitions.ExcelOperations.ReadData(1, "Url");
            GlobalDefinitions.driver.Navigate().GoToUrl(pathurl);

            GlobalDefinitions.driver.Manage().Window.Maximize();

            //Click on Sign In tab
            SignIntab.Click();
            Thread.Sleep(500);

            //Enter the data in Username textbox
            Email.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "Username"));
            Thread.Sleep(500);

            //Enter the password
            Password.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "Password"));
            Thread.Sleep(500);

            //Click on Login button
            LoginBtn.Click();
          Thread.Sleep(3000);

            ////Verification
            //Thread.Sleep(1000);
            //string msg = GlobalDefinitions.ExcelOperations.ReadData(1, "DATA");
            //string Actualmsg = Test.Text;
            //Thread.Sleep(500);
            //if (msg == Actualmsg)
            //{
            //    Console.WriteLine("Login into application");
            //}

            //else
            //    Console.WriteLine("Login Fail");
        }

    }
}
