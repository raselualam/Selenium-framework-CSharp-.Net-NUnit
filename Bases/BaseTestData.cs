using OpenQA.Selenium;

namespace MyNamespace
{
    public class BaseTestData
    {
        protected IWebDriver driver;

        public BaseTestData(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
