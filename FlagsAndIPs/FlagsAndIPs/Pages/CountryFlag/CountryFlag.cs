using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlagsAndIPs.Pages.AllCountriesList;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace FlagsAndIPs.Pages.CountryFlag
{
    public partial class CountryFlag : BasePage
    {
        protected string flagURL = ConfigurationManager.AppSettings["FlagURL"];

        public CountryFlag(IWebDriver driver) : base(driver)
        {
        }

        public string URL
        {
            get
            {

                return this.flagURL;
            }
        }

        public void CountryFlagNavigateTo(string country)
        {
            this.Driver.Navigate().GoToUrl(this.URL + country);
        }

        public void ScreenshotCountryMap(string country)
        {
            this.CountryFlagNavigateTo(country);

            var screenshot = ((ITakesScreenshot)this.Driver).GetScreenshot();
            string filepath = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["Screenshots"];
            string filename = $"{this.CountryName.Text}-+{this.CapitalName.Text}-+{this.CountryCode.Text}";
            
            Actions action = new Actions(this.Driver);
            action.MoveToElement(this.Map);
            action.Perform();
            
            screenshot.SaveAsFile(filepath + filename + ".jpg", ScreenshotImageFormat.Jpeg);
        }
    }
}
