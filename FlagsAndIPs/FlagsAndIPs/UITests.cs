using FlagsAndIPs.Pages.AllCountriesList;
using FlagsAndIPs.Pages.CountryFlag;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FlagsAndIPs
{
    public class UITests
    {
        private IWebDriver driver;

        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
        }

        [Test]
        [Property("Flags Of All Countries", 3)]
        [Author("Петя Николова")]

        public void FlagCountry()
        {
            BasePage basePage = new BasePage(this.driver);
            basePage.NavigateTo();
            AllCountriesList countriesList = new AllCountriesList(this.driver);
            countriesList.EuroCountriesNavigateTo();
            List<string> country = new List<string>();            
            CountryFlag flagCountry = new CountryFlag(this.driver);
            country = countriesList.ContainerAllCountries;
            for (int i=0;i< country.Count; i++)
            {                                
                flagCountry.ScreenshotCountryMap(country[i]);
                //flagCountry.ScreenshotCountryMap(countriesList.ContainerAllCountries[i].Text);                            
            }                     
        }

        [Test]
        [Category("IPs Ranges Of All Countries")]        
        [TestOf("All IP Ranges For All European Countries")]
        [Author("Петя Николова")]

        public void IPsRangesEuropeanCoountries()
        {
            CountryIPs ip = new CountryIPs(this.driver);
            ip.IPNavigateTo();
        }
    }
}
