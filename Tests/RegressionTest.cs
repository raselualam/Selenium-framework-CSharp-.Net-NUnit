using NUnit.Framework;

namespace MyNamespace
{
    [TestFixture]
    public class RegressionTest : BaseFramework
    {
        //string Url;

        [Test]
        public void SampleTest()
        {
            ControllerOne().FunctionNavigateURL(TestData().Url());
            ControllerOne().FunctionSimple(TestData().UserName(), TestData().UserPass());
            ControllerOne().FunctionDropDown(TestData().SearchBy());
            ControllerOne().FunctionSwitchWindow(TestData().OtherURL());
            ControllerOne().FunctionAssert(TestData().Text());
            ControllerOne().FunctionWait(TestData().TimeSec());
            ControllerOne().FunctionAlertAccept();
            ControllerTwo().FunctionDrpDwn(TestData().Search(), TestData().Value());
            ControllerThree().FunctionLibrary();
        }

        [Test]
        public void SampleTest2()
        {
            ControllerOne().FunctionNavigateURL(TestData().Url());
            ControllerOne().FunctionSimple(TestData().UserName(), TestData().UserPass());
            ControllerOne().FunctionDropDown(TestData().SearchBy());
            ControllerOne().FunctionSwitchWindow(TestData().OtherURL());
            ControllerOne().FunctionAssert(TestData().Text());
            ControllerOne().FunctionWait(TestData().TimeSec());
        }

        [Test]
        public void SampleTest3()
        {
            ControllerOne().FunctionAssert(TestData().Text());
            ControllerOne().FunctionWait(TestData().TimeSec());
            ControllerOne().FunctionAlertAccept();
            ControllerTwo().FunctionDrpDwn(TestData().Search(), TestData().Value());
            ControllerThree().FunctionLibrary();
        }

    }
}