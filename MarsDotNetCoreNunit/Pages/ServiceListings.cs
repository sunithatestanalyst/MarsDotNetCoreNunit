//using AutoItX3Lib;
//using MarsDotNetCoreNunit.Global;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium.Support.PageObjects;
//using OpenQA.Selenium.Support.UI;
//using System;
//using System.Linq;
//using System.Threading;


//namespace MarsDotNetCoreNunit.Pages
//{
//    class ServiceListings
//    {
       
//        //Locate Title 
//        private IWebElement Title = GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"));
       
//        //Locate Description
//         private IWebElement Description = GlobalDefinitions.driver.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));

//        //Category
//        private IWebElement Category = GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='categoryId']"));

//        //SubCategory
//        private IWebElement Subcategory = GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='subcategoryId']"));

//        //Tag outer
//        private IWebElement Tagouter= GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(@class,'form-wrapper field error')]"));

//        //Tag to inner text field
//         private IWebElement TagInner = GlobalDefinitions.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[4]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
        
//        //Service type One off Service
//        private IWebElement ServiceOne = GlobalDefinitions.driver.FindElement(By.XPath("//form[@class='ui form']//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]"));

//        //Service type Hourly basis service
//         private IWebElement ServiceHourly = GlobalDefinitions.driver.FindElement(By.XPath(" //form[@class='ui form']//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]"));

//        //Location type Onsite
//        private IWebElement LocationOnsite = GlobalDefinitions.driver.FindElement(By.XPath("//form[@class='ui form']//div[6]//div[2]//div[1]//div[1]//div[1]//input[1]"));

//        //Start date
//        private IWebElement StartDate = GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Start date']"));

//        //End Date
//         private IWebElement EndDate = GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='End date']"));

//        //Location type Online
//         private IWebElement LocationOnline = GlobalDefinitions.driver.FindElement(By.XPath("//form[@class='ui form']//div[6]//div[2]//div[1]//div[2]//div[1]//input[1]"));

//        //Skill Trade - skill Exchange
//        private IWebElement SkillExcha = GlobalDefinitions.driver.FindElement(By.XPath("//form[@class='ui form']//div[8]//div[2]//div[1]//div[1]//div[1]//input[1]"));

//        //Skill trade - credit
//         private IWebElement Skillcredit = GlobalDefinitions.driver.FindElement(By.XPath("//form[@class='ui form']//div[8]//div[2]//div[1]//div[2]//div[1]//input[1]"));

//        //Skill Exchange
//         private IWebElement SkillExchange = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//input[@placeholder='Add new tag']"));

//        //credit
//         private IWebElement Credit = GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Amount']"));

//        // Work Samples
//        private IWebElement Samples = GlobalDefinitions.driver.FindElement(By.XPath("//i[@class='huge plus circle icon padding-25']"));

//        //Active
//        private IWebElement Active = GlobalDefinitions.driver.FindElement(By.XPath("//label[contains(text(),'Hidden')]"));

//        //Save
//        private IWebElement Save = GlobalDefinitions.driver.FindElement(By.XPath("//input[@value='Save']"));

//        //cancel
//        private IWebElement Cancel = GlobalDefinitions.driver.FindElement(By.XPath("//input[@value='Cancel']"));

//        //Days selection
//        private IWebElement Days = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[2]//div[1]//div[1]//input[1]"));

//       //time selection
//        private IWebElement time = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[2]//div[2]//input[1]"));

//        //Title validation message
//        private IWebElement TitleValidation = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ui basic red prompt label transition visible']"));

//        //Description validation message for invalid
//         private IWebElement DescriptionValidation = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ui basic red prompt label transition visible']"));

//        //Description validation for null 
//         private IWebElement DescriptionValidationNull = GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(text(),'Description is required')]"));

//        //Category validation message
//         private IWebElement CategoryValidation = GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(text(),'Category is required')]"));

//        //subcategory validation message
//         private IWebElement SubcategoryValidation = GlobalDefinitions.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[3]/div[2]/div[1]/div[2]/div[2]/div[1]"));

//        //start date validation message
//        private IWebElement StartDateValidation = GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(text(),'Start Date cannot be set to a day in the past')]"));

//        // Tag validation message
//         private IWebElement TagValidation = GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(text(),'Tags are required')]"));

//        //skill exchange validation
//        private IWebElement ExchangeValidation = GlobalDefinitions.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[4]/div[2]"));

       

//        #region Adding service with valid values
//                internal bool ShareSkill()
//        {
//            try
//            {
             
//                //Populate From Excel
//                GlobalDefinitions.ExcelOperations.PopulateInCollection(GlobalDefinitions.ReadJson(), "ShareSkill");
                    
//                Thread.Sleep(2000);

//                //Enter Title
//                Title.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "Title"));

//                //Enter Description
//                Description.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "Description"));

//                Thread.Sleep(2000);
//                //Select Category
//                SelectElement Categories = new SelectElement(Category);
//                Categories.SelectByText(GlobalDefinitions.ExcelOperations.ReadData(1, "Category"));

//                //select Sub category
//                SelectElement SubCategories = new SelectElement(Subcategory);
//                SubCategories.SelectByText(GlobalDefinitions.ExcelOperations.ReadData(1, "Subcategory"));

//                Thread.Sleep(2000);
//                //Enter Tags
//                TagInner.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "Tags"));
//                TagInner.SendKeys(Keys.Enter);

//                //Service type
//                string ServiceToSelect = GlobalDefinitions.ExcelOperations.ReadData(1, "ServiceType");
//                if (ServiceToSelect == "One-off service")
//                {
//                    ServiceOne.Click();
//                }
//                else if (ServiceToSelect == "Hourly basis service")
//                {
//                    ServiceHourly.Click();
//                }

//                //select Location type
//                string Locationtype = GlobalDefinitions.ExcelOperations.ReadData(1, "LocationType");
//                if (Locationtype == "On-site")
//                {
//                    LocationOnsite.Click();

//                }
//                else if (Locationtype == "Online")
//                {
//                    LocationOnline.Click();
//                }
//                Thread.Sleep(2000);
//                string SDate = GlobalDefinitions.ExcelOperations.ReadData(1, "StartDate");
//                string[] SDateForm = SDate.Split(' ');

//                StartDate.SendKeys(SDateForm[0]);

//                string EDate = GlobalDefinitions.ExcelOperations.ReadData(1, "EndDate");
//                string[] EDateForm = EDate.Split(' ');

//                EndDate.SendKeys(EDateForm[0]);

//                Thread.Sleep(2000);
//                string days = GlobalDefinitions.ExcelOperations.ReadData(1, "AvailableDays");
//                string DaysToLwercase = days.ToLower();

//                string[] Dayslist = DaysToLwercase.Split(',');
//                int count = Dayslist.Count();

//                string StartTimevalue = GlobalDefinitions.ExcelOperations.ReadData(1, "StartTime");
//                string[] Starttimelist = StartTimevalue.Split(',');


//                string EndTimeValue = GlobalDefinitions.ExcelOperations.ReadData(1, "EndTime");
//                string[] EndTimelist = EndTimeValue.Split(',');


//                for (int i = 0; i <= count - 1; i++)
//                {
//                    if (Dayslist[i].ToLower() == "sunday")
//                    {

//                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[2]//div[1]//div[1]//input[1]")).Click();
//                        IWebElement StartTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[2]//div[2]//input[1]"));
//                        IWebElement EndTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[2]//div[3]//input[1]"));
//                        StartTime.SendKeys(Starttimelist[i]);
//                        EndTime.SendKeys(EndTimelist[i]);
//                    }
//                    else if (Dayslist[i].ToLower() == "monday")
//                    {
//                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[3]//div[1]//div[1]//input[1]")).Click();
//                        IWebElement StartTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[3]//div[2]//input[1]"));
//                        IWebElement EndTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[3]//div[3]//input[1]"));
//                        StartTime.SendKeys(Starttimelist[i]);
//                        EndTime.SendKeys(EndTimelist[i]);

//                    }
//                    else if (Dayslist[i].ToLower() == "tuesday")
//                    {
//                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[4]//div[1]//div[1]//input[1]")).Click();
//                        IWebElement StartTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[4]//div[2]//input[1]"));
//                        IWebElement EndTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[4]//div[3]//input[1]"));
//                        StartTime.SendKeys(Starttimelist[i]);
//                        EndTime.SendKeys(EndTimelist[i]);
//                    }

//                    else if (Dayslist[i].ToLower() == "wednesday")
//                    {
//                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[5]//div[1]//div[1]//input[1]")).Click();
//                        IWebElement StartTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[5]//div[2]//input[1]"));
//                        IWebElement EndTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[5]//div[3]//input[1]"));
//                        StartTime.SendKeys(Starttimelist[i]);
//                        EndTime.SendKeys(EndTimelist[i]);
//                    }

//                    else if (Dayslist[i].ToLower() == "thursday")
//                    {
//                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[6]//div[1]//div[1]//input[1]")).Click();
//                        IWebElement StartTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[6]//div[2]//input[1]"));
//                        IWebElement EndTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[6]//div[3]//input[1]"));
//                        StartTime.SendKeys(Starttimelist[i]);
//                        EndTime.SendKeys(EndTimelist[i]);
//                    }
//                    else if (Dayslist[i].ToLower() == "friday")
//                    {
//                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[7]//div[1]//div[1]//input[1]")).Click();
//                        IWebElement StartTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[7]//div[2]//input[1]"));
//                        IWebElement EndTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[7]//div[3]//input[1]"));
//                        StartTime.SendKeys(Starttimelist[i]);
//                        EndTime.SendKeys(EndTimelist[i]);
//                    }

//                    else if (Dayslist[i].ToLower() == "saturday")
//                    {
//                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[8]//div[1]//div[1]//input[1]")).Click();
//                        IWebElement StartTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[8]//div[2]//input[1]"));
//                        IWebElement EndTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[8]//div[3]//input[1]"));
//                        StartTime.SendKeys(Starttimelist[i]);
//                        EndTime.SendKeys(EndTimelist[i]);
//                    }
//                }


//                //select Skill trade
//                string SkillTrade = GlobalDefinitions.ExcelOperations.ReadData(1, "SkillTrade");
//                if (SkillTrade == "Credit")
//                {
//                    Skillcredit.Click();
//                    //Add credit
//                    Credit.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "Credit"));
//                }
//                else if (SkillTrade == "Skill-exchange")
//                {
//                    SkillExcha.Click();

//                    //Add Skill Exchange
//                    SkillExchange.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(1, "SkillExchange"));
//                    SkillExchange.SendKeys(Keys.Enter);
//                }

//                Samples.Click();
//                Thread.Sleep(2000);
//                AutoItX3 file = new AutoItX3();
//                file.WinActivate("Open");
//                file.Send(GlobalDefinitions.ExcelOperations.ReadData(1, "WorkSamples"));
//                Thread.Sleep(1000);
//                file.Send("{ENTER}");

//                Thread.Sleep(2000);

//                Save.Click();

//                Thread.Sleep(2000);
//                return true;
//            }

//            catch (Exception e)
//            {

                
//                return false;
//            }
//        }
//        #endregion
//        #region Invalid values
//        internal bool ShareSkillInvalid()
//        {

//            try
//            {

//                //Populate From Excel
//                GlobalDefinitions.ExcelOperations.PopulateInCollection(GlobalDefinitions.ReadJson(), "ShareSkill");
//                Thread.Sleep(2000);

//                //Enter Title
//                Title.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(2, "Title"));

//                //Enter Description
//                Description.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(2, "Description"));

//                Thread.Sleep(2000);

//                //Enter Tag
//                TagInner.SendKeys(GlobalDefinitions.ExcelOperations.ReadData(2, "Tags"));


//                string SInDate = GlobalDefinitions.ExcelOperations.ReadData(2, "StartDate");
//                string[] SInDateForm = SInDate.Split(' ');
//                StartDate.SendKeys(SInDateForm[0]);

//                string EInDate = GlobalDefinitions.ExcelOperations.ReadData(2, "EndDate");
//                string[] EInDateForm = EInDate.Split(' ');
//                EndDate.SendKeys(EInDateForm[0]);
//                //Click Save
//                Save.Click();
//                return true;
//            }

//            catch (Exception)
//            {
//                return false;
//            }

//        }

//        internal void InvalidValueValidation()
//        {

//            try
//            {
//                Thread.Sleep(3000);
//                //Title validation message

//                string ActualTitleValidationmsg = TitleValidation.Text;
//                if ((ActualTitleValidationmsg == "First character must be an alphabet character or a number.") || (ActualTitleValidationmsg == "Special characters are not allowed."))
//                {
//                    Console.WriteLine("Title Validation message is displayed correctly");
//                }
//                else
//                {
//                    Console.WriteLine("Title Validation message is not displayed correctly");
//                }
//                Thread.Sleep(2000);

//                //Description validation message
//                string ActualDescriptionValidationmsg = DescriptionValidation.Text;
//                if ((ActualDescriptionValidationmsg == "First character must be an alphabet character or a number.") || (ActualDescriptionValidationmsg == "Special characters are not allowed."))
//                {
//                    Console.WriteLine("Description Validation message is displayed correctly");
//                }
//                else
//                {
//                    Console.WriteLine("Description Validation message is not displayed correctly");
//                }

//                //category validation 
//                string ActualCategoryValidationmsg = CategoryValidation.Text;
//                if (ActualCategoryValidationmsg == "Category is required")
//                {
//                    Console.WriteLine("Category Validation message is displayed correctly");
//                }
//                else
//                {
//                    Console.WriteLine("Category Validation message is not displayed correctly");
//                }


//                IJavaScriptExecutor js = (IJavaScriptExecutor)Global.GlobalDefinitions.driver;
//                js.ExecuteScript("window.scrollBy(0,1200)");

//                //Start date validation
//                string ExpectedStartDateValidaion = StartDateValidation.Text;
//                if ((ExpectedStartDateValidaion == "Start Date cannot be set to a day in the past") || (ExpectedStartDateValidaion == "Start Date shouldn't be greater than End Date"))
//                {
//                    Console.WriteLine("StartDate Validation message is displayed correctly");
//                }
//                else
//                {
//                    Console.WriteLine("StartDate Validation message is not displayed correctly");
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Error in validating Invalid values" + e.Message);
//            }
//        }
//        #endregion
//        #region Null values
//        internal void NullValueValidation()
//        {

//            try
//            {
//                Save.Click();

//                Thread.Sleep(3000);
//                //Title validation message

//                string ActualTitleValidationmsg = TitleValidation.Text;
//                if (ActualTitleValidationmsg == "Title is required")
//                {
//                    Console.WriteLine("Title Validation message is displayed correctly");
//                }
//                else
//                {
//                    Console.WriteLine("Title Validation message is not displayed correctly");
//                }
//                Thread.Sleep(2000);

//                //Description validation message

//                string ActualDescriptionValidationmsg = DescriptionValidationNull.Text;
//                if ((ActualDescriptionValidationmsg == "Description is required"))
//                {
//                    Console.WriteLine("Description Validation message is displayed correctly");
//                }
//                else
//                {
//                    Console.WriteLine("Description Validation message is not displayed correctly");
//                }

//                //category validation 
//                string ActualCategoryValidationmsg = CategoryValidation.Text;
//                if (ActualCategoryValidationmsg == "Category is required")
//                {
//                    Console.WriteLine("Category Validation message is displayed correctly");
//                }
//                else
//                {
//                    Console.WriteLine("Category Validation message is not displayed correctly");
//                }

//                //Tag validation
//                string ExpectedTagValidation = TagValidation.Text;
//                if (ExpectedTagValidation == "Tags are required")
//                {
//                    Console.WriteLine("Tag Validation message is displayed correctly");
//                }

//                else
//                {
//                    Console.WriteLine("Tag Validation message is not displayed correctly");
//                }

//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Error in validating null values" + e.Message);
//            }
//        }
//        #endregion
//    }

//}

