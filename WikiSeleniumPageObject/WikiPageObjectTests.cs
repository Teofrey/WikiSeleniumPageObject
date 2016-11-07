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
        public void ShouldLoadHomePageWhenClickOnLogo()
        {
			mainPage.ClickOnLogo();

			Assert.IsTrue(mainPage.IsPageLoaded());
        }

        [TestMethod]
        public void ShouldFindOneResultWhenSearchForKroll()
        {
			mainPage.TypeInSearchTerm(ObjectRepository.MainPage.KrollValue);

            mainPage.PerformSearch();

            Assert.IsTrue(mainPage.IsKOSearched());
		}
	}
}
