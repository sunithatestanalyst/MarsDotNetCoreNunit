
using MarsDotNetCoreNunit.Pages;
using MarsDotNetCoreNunit.Global;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MarsDotNetCoreNunit
{
    [TestFixture]
    public class Program
    {


        [SetUp]
        public void Inititalize()
        {
            //Inititalize driver
            string driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                                 
            GlobalDefinitions.driver = new ChromeDriver(driverPath);
            SignIn newSignIn = new SignIn();
            newSignIn.LoginSteps();


        }

        [TearDown]
        public void TearDown()
        {

            //close the driver
           // GlobalDefinitions.driver.Close();

        }


        [Test, Description("To Check if user is able to save service with all valid data")]
            public void AddShareSkill()
            {

                         
              Profile pobj = new Profile();
             bool clickstatus = pobj.ClickShareSkill();
            Thread.Sleep(2000);

            ListingsService listingsobj = new ListingsService();

            if (clickstatus == true)
                {
                    bool status = listingsobj.ShareSkill();

                if (status == true)
                {
                    ManageListings obj = new ManageListings();
                    obj.ListingVerification();
                }
            }

        }
            //[Test, Description("To Check if user is able to save service with invalid data")]
            //public void AddServiceWithInvalidValues()
            //{
            //// Create an class and object to call the method
            //ListingsService lobj = new ListingsService();
            //Profile pobj = new Profile();
            //pobj.ClickShareSkill();

            //ListingsService listingsobj = new ListingsService();
            //    bool result = listingsobj.ShareSkillInvalid();
            //    if (result)
            //    {
            //        listingsobj.InvalidValueValidation();
            //    }


            //}
            //[Test, Description("To check  mandatory fields are validated for null values")]
            //public void AddServiceWithNullValues()
            //{
            //// Create an class and object to call the method
            //ListingsService lobj = new ListingsService();
            //Profile pobj = new Profile();
            //pobj.ClickShareSkill();


            //ListingsService listingsobj = new ListingsService();
            //    listingsobj.NullValueValidation();
            //}
        }
    }
