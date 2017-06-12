using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;

namespace FlagsAndIPs
{
    // Include constructors, properties

    public class BasePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        protected string url = ConfigurationManager.AppSettings["URL"];
        public readonly log4net.ILog log =
           log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(60));
        }

        public IWebDriver Driver
        {
            get
            {
                return this.driver;
            }
        }

        public WebDriverWait Wait
        {
            get
            {
                return this.wait;
            }
        }

        public string Url
        {
            get
            {
                return this.url;
            }
        }
        
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.Url);
        }
    }
}
