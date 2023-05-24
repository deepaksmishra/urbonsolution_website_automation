using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static urbonsolution_website_automation.GlobalMessage.Message;


namespace urbonsolution_website_automation.TestScripts
{
    class EntryPoint
    {

        static IWebDriver driver = new ChromeDriver();
        static IAlert alert;
        static IWebElement Image;


        static void Main()
        {
            string url = "https://www.urbonsolution.com/";
            driver.Navigate().GoToUrl(url);
            alert = driver.SwitchTo().Alert();
            alert.Accept();
            Image = driver.FindElement(By.CssSelector("body > div.sgpb-basic-bottom-left.sgpb-floating-button.sg-popup-id-5517"));
            if (Image.Displayed)
            {
                SucessMessage("FirstName Element by ID Found successfully!!!");

            }
            else
            {
                FailMessage("No Response!!");
            }
            Console.WriteLine(alert.Text);
            Thread.Sleep(2300);
            driver.Quit();


        }

    }
}

