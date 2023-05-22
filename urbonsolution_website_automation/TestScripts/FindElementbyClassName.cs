using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V111.Page;
using static urbonsolution_website_automation.GlobalMessage.Message;


namespace urbonsolution_website_automation.Test
{
    internal class FindElementbyClassName
    {
        static void Main(string[] args)
        {

             
                string class_name = "ff-el-form-control";
                string url = "https://www.urbonsolution.com/contacts/";


                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                IWebElement element = driver.FindElement(By.ClassName(class_name));
                if (element.Displayed)
                {
                    SucessMessage("Element by Class Name Found successfully!!!");

                }
                else
                {
                    FailMessage("Element Not Found by name @@");

                }

                Thread.Sleep(10000);
                driver.Quit();


            }

        }
    }

