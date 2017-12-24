using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace MyNamespace
{
    public enum BrowserType
    {
        Chrome,
        Firefox,
        IE
    }

    [TestFixture]
    public class ParallelTestHook : BaseHook
    {
        private BrowserType _browserType;

        public ParallelTestHook(BrowserType browser)
        {
            _browserType = browser;
        }

        [SetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);
        }

        private void ChooseDriverInstance(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
                driver = new ChromeDriver();
            else if (browserType == BrowserType.Firefox)
                driver = new FirefoxDriver();
        }
    }
}
