using OpenQA.Selenium;

namespace MyNamespace
{
    public class BaseStep
    {
        protected IWebDriver driver;

        public BaseStep (IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
