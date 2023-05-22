using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static urbonsolution_website_automation.GlobalMessage.Message;

namespace urbonsolution_website_automation.Test
{
    class FindElementbyID
    {
        public FindElementbyID()
        {
            string url = "https://www.urbonsolution.com/contacts/";
            string ID = "ff_1_names_first_name_";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            IWebElement element = driver.FindElement(By.Id(ID));
            if (element.Displayed)
            {
                SucessMessage("FirstName Element by ID Found successfully!!!");

            }
            else
            {
                FailMessage("No Response!!");
            }

        }


    }
}
