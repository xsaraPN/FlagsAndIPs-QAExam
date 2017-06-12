using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsAndIPs.Pages.CountryFlag
{
    public partial class CountryFlag
    {
        public IWebElement Map
        {
            get
            {
                return this.Wait.Until(w => w.FindElement(By.CssSelector("#map-wrapper")));
            }
        }
        
        public IWebElement CountryName
        {
            get
            {
                return this.Wait.Until(w => w.FindElement(By.XPath("//*[@id=\"content\"]/dl[1]/dd[2]")));
            }
        }

        public IWebElement CountryCode
        {
            get
            {
                return this.Wait.Until(w => w.FindElement(By.CssSelector("#content > dl:nth-child(8) > dd:nth-child(2) > span.emoji")));
            }
        }

        public IWebElement CapitalName
        {
            get
            {
                return this.Wait.Until(w => w.FindElement(By.CssSelector("#content > dl:nth-child(8) > dd:nth-child(6)")));
            }
        }
    }
}
