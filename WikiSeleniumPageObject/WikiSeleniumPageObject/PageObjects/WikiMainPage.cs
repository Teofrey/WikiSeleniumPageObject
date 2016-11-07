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

        [FindsBy(How = How.Id , Using = ObjectRepository.MainPage.SearchId)]
        public IWebElement searchBox;

        [FindsBy(How = How.Id, Using = ObjectRepository.MainPage.SearchButton)]
        public IWebElement searchButton;
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
        
        public void PerformSearch(String textToSearch)
        {
            searchBox.SendKeys(textToSearch);
            searchButton.Click();
        }

        public bool IsKOSearched()
        {
            var WikiKo = driver.FindElement(ObjectRepository.MainPage.WikiKO);
            return WikiKo.Text.Contains(ObjectRepository.MainPage.KrollEx);
        }
            
    }


}

