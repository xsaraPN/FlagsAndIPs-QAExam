using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsAndIPs.Pages.AllCountriesList
{
    public partial class AllCountriesList : BasePage
    {
        public AllCountriesList(IWebDriver driver) : base(driver)
        {
        }

        public string URL
        {
            get
            {

                return base.Url + "all-countries.html";
            }
        }

        public void AllCountriesNavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.URL);
        }


        public void EuroCountriesNavigateTo()
        {
            this.Driver.Navigate().GoToUrl(base.Url + "countries-of-europe.html");
        }
    }
}
