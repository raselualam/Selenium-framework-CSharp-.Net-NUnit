using OpenQA.Selenium;

namespace MyNamespace
{
    public class StepsThree : BaseStep
    {
        public PageThree PageThreeModel = null;

        public StepsThree(IWebDriver driver) : base(driver)
        {
            PageThreeModel = new PageThree(driver);
        }

        public void FunctionLibrary ()
        {
            PageThreeModel.BtnPageObject().Click();
        }
    }
}
