using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiSeleniumPageObject.PageObjects
{
    public class WikiMainPage
    {
        public IWebDriver driver;

        public WikiMainPage()
        {
            driver = new ChromeDriver();
            LoadPage();
        }

        public void LoadPage()
        {
            driver.Navigate().GoToUrl(ObjectRepository.MainPage.MainPageUrl);
        }

        public void Close()
        {
            driver.Quit();
        }

        public bool IsPageLoaded()
        {
            var WikiEx = driver.FindElement(ObjectRepository.MainPage.WelcomTextId);
            return WikiEx.Text.Contains(ObjectRepository.MainPage.WelcomeText);
        }

	    public void TypeInSearchTerm(string textToSearch)
		{
			IWebElement searchBox = driver.FindElement(By.Id(ObjectRepository.MainPage.SearchId));
			searchBox.SendKeys(textToSearch);

		}
        
        public void PerformSearch()
		{
			IWebElement searchButton = driver.FindElement(By.Id(ObjectRepository.MainPage.SearchButton));
			searchButton.Click();
        }

        public bool IsKOSearched()
        {
            var WikiKo = driver.FindElement(ObjectRepository.MainPage.WikiKO);
            return WikiKo.Text.Contains(ObjectRepository.MainPage.KrollEx);
        }

	    public void ClickOnLogo()
	    {
			IWebElement wikiLogo = driver.FindElement(By.Id(ObjectRepository.MainPage.LogoIconId));
			wikiLogo.Click();
	    }
    }


}

