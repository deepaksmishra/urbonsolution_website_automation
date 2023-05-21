using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace urbonsolution_website_automation.Test
{
    class Homepagetest
    {

        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.urbonsolution.com/");
            Thread.Sleep(10000);
            driver.Quit();


        }
    }
}
