using MarsDotNetCoreNunit.Global;
using NUnit.Framework;
using OpenQA.Selenium;


namespace MarsDotNetCoreNunit.Pages
{
    class ManageListings
    {

       internal void ListingVerification()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelOperations.PopulateInCollection(GlobalDefinitions.ReadJson(), "ShareSkill");
            
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]"), 5);

            IWebElement Title = GlobalDefinitions.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]"));

            Assert.AreEqual(Title.Text, GlobalDefinitions.ExcelOperations.ReadData(2, "Title"));
                                   
        }
    }
}
