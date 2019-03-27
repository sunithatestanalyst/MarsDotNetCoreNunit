using ExcelDataReader;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace MarsDotNetCoreNunit.Global
{
    class GlobalDefinitions
    {

        //initialise driver
        public static IWebDriver driver { get; set; }

        //Reading values from json file
        public static string ReadJson()
        {
            var Client = new WebClient();
            var json = Client.DownloadString(@"C:\Users\CC-MTR\Documents\Saranya\MARS\MarsDotNetCoreNunit\MarsDotNetCoreNunit\Global\Marsconfig.json");
            dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            var path = result.Paths.ExcelPath;
            return path;

        }
        public static void wait(int time)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);

        }
        public static IWebElement WaitForElement(IWebDriver driver, By by, int timeOutinSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return (wait.Until(ExpectedConditions.ElementIsVisible(by)));
        }

               
        public class ExcelOperations
        {
            static List<DataCollection> dataCol = new List<DataCollection>();
            private static DataTable ExcelToDataTable(string filename, string sheetName)
            {
                try
                {
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                    FileStream stream = File.Open(filename, FileMode.Open, FileAccess.Read);

                    IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    //excelReader.IsFirstRowAsColumnNames = true; //Does not work any more

                    DataSet resultSet = excelReader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }

                    });

                    DataTableCollection table = resultSet.Tables;
                    DataTable resultTable = table[sheetName];
                    return resultTable;
                }
                catch (Exception e)
                {
                    throw;
                }


            }
            public class DataCollection
            {

                public int rowNumber { get; set; }
                public string colName { get; set; }
                public string colValue { get; set; }
            }


            // static List<DataCollection> dataCol = new List<DataCollection>();

            public static void ClearData()
            {
                dataCol.Clear();
            }

            public static void PopulateInCollection(string filename, string sheetName)
            {
                ExcelOperations.ClearData();
                DataTable table = ExcelToDataTable(filename, sheetName);
                for (int row = 1; row <= table.Rows.Count; row++)
                {
                    for (int col = 0; col < table.Columns.Count; col++)
                    {
                        DataCollection dtTable = new DataCollection()
                        {
                            rowNumber = row,
                            colName = table.Columns[col].ColumnName,
                            colValue = table.Rows[row - 1][col].ToString()

                        };
                        dataCol.Add(dtTable);
                    }
                }
            }



            public static string ReadData(int rowNumber, string columnName)
            {
                try
                {
                    string data = (from colData in dataCol where colData.colName == columnName && colData.rowNumber == rowNumber select colData.colValue).SingleOrDefault();
                    //  string data = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).Select(x => x.colValue).SingleOrDefault();
                    return data.ToString();
                }
                catch (Exception e)
                {
                    return null;

                }
            }

        }

    }
}
