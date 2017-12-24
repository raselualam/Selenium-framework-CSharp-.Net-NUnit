using System.Xml;
using OpenQA.Selenium;
using System.Configuration;

namespace MyNamespace
{ 
    public class DataModel : BaseTestData
    {
        public DataModel(IWebDriver driver) : base(driver)
        {
        }

        public string Url()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load(ConfigurationManager.AppSettings["DataFilePath"]);
            return (myXml.GetElementsByTagName("Url"))[0].InnerText;
        }

        public string UserName()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load(ConfigurationManager.AppSettings["DataFilePath"]);
            return (myXml.GetElementsByTagName("UserName"))[0].InnerText;
        }

        public string UserPass()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load(ConfigurationManager.AppSettings["DataFilePath"]);
            return (myXml.GetElementsByTagName("UserPass"))[0].InnerText;
        }

        public string SearchBy()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load(ConfigurationManager.AppSettings["DataFilePath"]);
            return (myXml.GetElementsByTagName("SearchBy"))[0].InnerText;
        }

        public string OtherURL()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load(ConfigurationManager.AppSettings["DataFilePath"]);
            return (myXml.GetElementsByTagName("OtherURL"))[0].InnerText;
        }

        public string Text()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load(ConfigurationManager.AppSettings["DataFilePath"]);
            return (myXml.GetElementsByTagName("Text"))[0].InnerText;
        }

        public int TimeSec()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load(ConfigurationManager.AppSettings["DataFilePath"]);
            return int.Parse((myXml.GetElementsByTagName("TimeSec"))[0].InnerText);
        }

        public string Search()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load(ConfigurationManager.AppSettings["DataFilePath"]);
            return (myXml.GetElementsByTagName("Search"))[0].InnerText; ;
        }

        public string Value()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load(ConfigurationManager.AppSettings["DataFilePath"]);
            return (myXml.GetElementsByTagName("Value"))[0].InnerText; ;
        }
    }
}
