using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MyNamespace
{
    public class StepsTwo : BaseStep
    {
        public PageTwo PageTwoModel = null;

        public StepsTwo(IWebDriver driver) : base(driver)
        {
            PageTwoModel = new PageTwo(driver);
        }

        public void FunctionDrpDwn (string SearchBy, string Value)
        {
            SelectElement mydrpdwn = new SelectElement(PageTwoModel.DDPGobj1());
            mydrpdwn.SelectByText(SearchBy);
            PageTwoModel.TxtPGobj2().Clear();
            PageTwoModel.TxtPGobj2().SendKeys(Value);
            PageTwoModel.BtnPGobj3().Click();
        }
    }
}
