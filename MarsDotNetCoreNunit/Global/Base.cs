//using MarsDotNetCore.Pages;
//using MarsDotNetCoreNunit.Global;
//using NUnit.Framework;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
//using System;
//using System.IO;
//using System.Reflection;

//namespace MarsDotNetCoreNunit.Global
//{
//    public class Base
//    {
       
//        #region setup and tear down
//        [SetUp]
//        public void Inititalize()
//        {
//            //Inititalize driver
//             string driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
//             GlobalDefinitions.driver = new ChromeDriver(driverPath);

//            //using (GlobalDefinitions.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
//            //{

//                SignIn newSignIn = new SignIn();
//                newSignIn.LoginSteps();

                
//            //}

//        }


//        [TearDown]
//        public void TearDown()
//        {
                       
//            //close the driver
//          //  GlobalDefinitions.driver.Close();
                                          
//        }
//        #endregion

//    }
//}