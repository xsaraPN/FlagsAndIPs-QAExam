using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsAndIPs
{
    public partial class CountryIPs : BasePage
    {
        protected string IPURL = ConfigurationManager.AppSettings["IPURL"];

        public CountryIPs(IWebDriver driver) : base(driver)
        {
        }

        public string URL
        {
            get
            {

                return this.IPURL;
            }
        }

        public void IPNavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.URL);
        }
        
    }
}
