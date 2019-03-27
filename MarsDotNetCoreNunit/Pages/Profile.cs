using MarsDotNetCoreNunit.Global;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsDotNetCoreNunit.Pages
{
    class Profile
    {
        private IWebElement ShareSkillBtn = GlobalDefinitions.driver.FindElement(By.XPath("//a[@class='ui basic green button']"));
        internal bool ClickShareSkill()
        {
            
             ShareSkillBtn.Click();
            return true;  

        }
    }
}
