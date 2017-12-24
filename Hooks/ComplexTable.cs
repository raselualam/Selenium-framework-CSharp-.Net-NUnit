using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyNamespace
{

    public class ComplexTable : Base
    {
        [Test]
        public void ComplexTableCheck()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://myurl/url.aspx");

            TablePage page = new TablePage();

            //read table
            Utilties.ReadTable(page.table);

            Console.WriteLine("**********************************");
            //Get the cell value from the table
            Console.WriteLine("The name {0} with Email {1} and Phone {2}",
                Utilties.ReadCell("Name", 2), Utilties.ReadCell("Email", 2), Utilties.ReadCell("Phone", 2));
            Console.WriteLine("**********************************");

            //Delete Prashanth
            Utilties.PerformActionOnCell("5", "Name", "Prashanth", "Delete");
            //Save Prashanth
            Utilties.PerformActionOnCell("5", "Name", "Prashanth", "Save");
            //Checkbox Prashanth
            Utilties.PerformActionOnCell("Option", "Name", "Prashanth");

            Console.Read();
        }

        [Test]
        public void ComplexTableTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://myUrl/url.aspx");
            Console.WriteLine("Using Nunit SetUp to Open Browser with Selenium Webdriver");
            SelectElement mydrpdwn = new SelectElement(driver.FindElement(By.XPath("//*[@id='ddlSample']")));
            mydrpdwn.SelectByText("sampleText");
            driver.FindElement(By.XPath("//*[@id='Value1']")).SendKeys("sampleString");
            driver.FindElement(By.XPath("//*[@id='test']")).Click();
            driver.FindElement(By.XPath("//*[@id='ComplexTable']/tbody/tr[22]/td[45]/a")).Click();
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.XPath(".//a[contains(@href,'fh123')]/img[contains(@src,'../images/pid.png')]")).Click();
            TablePage page = new TablePage();
            Utilties.ReadTable(page.table);
            Utilties.PerformActionOnCell("StringValue1", "StringValue2", "StringValue3");
        }
    }



    public class TablePage : Base
    {
        public TablePage()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id='sampleId']/tbody")]
        public IWebElement table { get; set;}
    }



    public class Base
    {
        public static IWebDriver driver;
    }



    public class TableDataCollection
    {
        public int RowNumber { get; set; }
        public string ColumnName { get; set; }
        public string ColumnValue { get; set; }
        public IEnumerable<IWebElement> ColumnSpecialValues { get; set; }
    }



    public class Utilties
    {
        static List<TableDataCollection> _tableDatacollections = new List<TableDataCollection>();

        public static void ReadTable(IWebElement table)
        {
            //Get all the Column from the table
            var columns = table.FindElements(By.TagName("td"));
            //Get all the raws from the table
            var rows = table.FindElements(By.TagName("tr"));
            //Create row index
            int rowIndex = 0;

            foreach (var row in rows)
            {
                int colIndex = 0;
                var colDates = row.FindElements(By.TagName("td"));
                foreach (var colValue in colDates)
                {
                    _tableDatacollections.Add(new TableDataCollection
                    {
                        RowNumber = rowIndex,
                        ColumnName = columns[colIndex].Text != "" ?
                                    columns[colIndex].Text : colIndex.ToString(),
                        ColumnValue = colValue.Text,
                        ColumnSpecialValues = colValue.Text != "" ? null :
                                              colValue.FindElements(By.TagName("img"))
                    });

                    //move to next column
                    colIndex++;
                }
                rowIndex++;
            }
        }

        public static string ReadCell(string columnName, int rowNumber) 
        {
            var data = (from e in _tableDatacollections
                        where e.ColumnName == columnName && e.RowNumber == rowNumber
                        select e.ColumnValue).SingleOrDefault();

            return data;
        }

        public static void PerformActionOnCell(string columnIndex, string refColumnName, string refColumnValue, string controlToOperate = null)
        {
            foreach (int rowNumber in GetDynamicRowNumber(refColumnName, refColumnValue))
            {
                var cell = (from e in _tableDatacollections
                            where e.ColumnName == columnIndex && e.RowNumber == rowNumber
                            select e.ColumnSpecialValues).SingleOrDefault();


                //Need to operate those controls
                if (controlToOperate != null && cell !=null)
                {
                    var returnedControl = (from c in cell
                                          where c.GetAttribute("src") == controlToOperate 
                                          select c).SingleOrDefault();
                    returnedControl?.Click();
                }
                else
                {
                    cell?.First().Click();
                }
             }
        }

        private static IEnumerable GetDynamicRowNumber(string columnName, string columnValue)
        {
            //dynamic row 
            foreach (var table in _tableDatacollections)
            {
                if (table.ColumnName == columnName && table.ColumnValue == columnValue)
                    yield return table.RowNumber;
            }
        }

    }
}
