using NUnit.Framework;

namespace MyNamespace
{
    [TestFixture]
    [Parallelizable]
    public class ParallelTestChrome : ParallelTestHook
    {

        public ParallelTestChrome() : base(BrowserType.Chrome)
        {
        }

        [Test]
        public void ParallelTestChromeW1()
        {  
            driver.Navigate().GoToUrl("http://myurl.com");
            driver.Manage().Window.Maximize();
        }
    }

    [TestFixture]
    [Parallelizable]
    public class ParallelTestChrome2 : ParallelTestHook
    {
        public ParallelTestChrome2() : base(BrowserType.Chrome)
        {
        }

        [Test]
        public void ParallelTestChromeW2()
        {
            driver.Navigate().GoToUrl("http://myurl.com");
            driver.Manage().Window.Maximize();
        }
    }

    [TestFixture]
    [Parallelizable]
    public class ParallelTestFirefox : ParallelTestHook
    {
        public ParallelTestFirefox() : base(BrowserType.Firefox)
        {
        }

        [Test]
        public void ParallelTestFirefoxW3()
        {
            driver.Navigate().GoToUrl("http://myurl.com");
            driver.Manage().Window.Maximize();
        }
    }

    [TestFixture]
    [Parallelizable]
    public class ParallelTestFirefox2 : ParallelTestHook
    {
        public ParallelTestFirefox2() : base(BrowserType.Firefox)
        {
        }

        [Test]
        public void ParallelTestFirefoxW4()
        {
            driver.Navigate().GoToUrl("http://myurl.com");
            driver.Manage().Window.Maximize();
        }
    }
}