using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WikiSeleniumPageObject.PageObjects
{
    internal class ObjectRepository
    {
        public class MainPage
        {
            public const string WelcomeText = "Witaj w Wikipedii,";
            public const string SearchId = "searchInput";
            public const string SearchButton = "searchButton";
            public static By WelcomTextId = By.Id("main-page-welcome");
            public static string MainPageUrl = "https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna";
            public const string KrollValue = "Kroll Ontrack";
            public const string KrollEx = "Kroll Ontrack[edytuj]";
            public static By WikiKO = By.Id("firstHeading");
	        public static string LogoIconId = "p-logo";
	        public static string TestValue = "Test";
        }
    }
}
