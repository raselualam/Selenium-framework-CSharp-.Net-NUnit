using OpenQA.Selenium;

namespace MyNamespace
{
    public class BasePage
    {
        protected IWebDriver driver; 

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
