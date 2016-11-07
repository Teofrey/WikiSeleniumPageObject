using Microsoft.VisualStudio.TestTools.UnitTesting;
using WikiSeleniumPageObject.PageObjects;

namespace WikiSeleniumPageObject
{
    [TestClass]
    public class WikiPageObjectTests
    {
        WikiMainPage mainPage;
        [TestInitialize]
        public void TestInitilize()
        {
            mainPage = new WikiMainPage();
            mainPage.LoadPage();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            mainPage.Close();
        }

        [TestMethod]
        public void ShouldISeeHomePage()
        {
            //var mainPage = new WikiMainPage();
            //mainPage.LoadPage();
            
            Assert.IsTrue(mainPage.IsPageLoaded());
        }

        [TestMethod]
        public void ShouldIFindKrollInfo()
        {
            //var mainPage = new WikiMainPage();
            //mainPage.LoadPage();

            mainPage.PerformSearch(ObjectRepository.MainPage.KrollValue);

            Assert.IsTrue(mainPage.IsKOSearched());

        }
    }
}
