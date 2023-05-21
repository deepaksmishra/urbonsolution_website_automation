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
    class FindElementByName
    {

        public void FindElementbyName()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.urbonsolution.com/contacts/");
            IWebElement element = driver.FindElement(By.Name("names[first_name]"));
            IWebElement lastname = driver.FindElement(By.Name("names[last_name]"));
            IWebElement number = driver.FindElement(By.Name("numeric-field"));
            IWebElement email = driver.FindElement(By.Name("email"));

            

            if (element.Displayed )
            {
                SucessMessage("FirstName Element Found successfully!!!");

            }
            if(lastname.Displayed)
            {
                SucessMessage("LastName Element Found successfully!!!");

            }
            if(number.Displayed)
            {
                SucessMessage("Number Element Found successfully!!!");
            }
            if (email.Displayed)
            {
                SucessMessage("Email Element Found successfully!!!");

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
