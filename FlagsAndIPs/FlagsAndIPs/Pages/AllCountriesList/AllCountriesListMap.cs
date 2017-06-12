using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsAndIPs.Pages.AllCountriesList
{
    public partial class AllCountriesList
    {        
        public List<string> ContainerAllCountries
        {
            get
            {
                //Execution time ~ 8sec
                var reminder = this.Wait.Until(w => w.FindElement(By.CssSelector("#content > div.container.list-container > div:nth-child(2)")));
                List<IWebElement> list = reminder.FindElements(By.TagName("ul")).ToList();
                List<string> classList = new List<string>();
                List<string> classListElement = new List<string>();
                List<string> elements = new List<string>();
                for (int i = 0; i < list.Count; i++)
                    classList.Add(list[i].Text);
                var reminder1="";
                for (int j = 0; j < classList.Count; j++)
                {
                    elements = classList[j].Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    
                    for (int el = 0; el < elements.Count; el++)
                    {
                        if (elements[el].Contains(" "))
                        {
                            elements[el].ToLower();
                            classListElement.Add(elements[el].Replace(" ", "-"));
                        }
                        else
                        {
                            elements[el].ToLower();
                            classListElement.Add(elements[el]);
                        }  
                       
                    }                        
                }
                                       
                for (int t = 0; t < classListElement.Count; t++)
                    if(classListElement[t].Length == 1)
                    {
                        classListElement.Remove(classListElement[t]);
                        t--;
                    }
                               
                

                /*
                // Execution time ~ 20sec
                var reminder = this.Wait.Until(w => w.FindElement(By.CssSelector("#content > div.container.list-container > div:nth-child(2)")));
                List <IWebElement> list = reminder.FindElements(By.TagName("li")).ToList();
                string className;
                for (int i = 0; i < list.Count; i++)
                {
                    className = list[i].GetAttribute("class");
                    if (className == "letter")
                    {
                        list.Remove(list[i]);
                        i--;
                    }

                }
                return list;*/
                return classListElement;
                
            }
        }


    }
}
