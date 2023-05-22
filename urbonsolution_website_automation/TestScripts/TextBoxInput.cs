using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace urbonsolution_website_automation.Test
{
    internal class TextBoxInput
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement textBox;

        static void Main()
        {

            string url = "https://www.urbonsolution.com/contacts/";
            driver.Navigate().GoToUrl(url);
            textBox = driver.FindElement(By.Name("names[first_name]"));
            textBox.SendKeys("Deepak");
            textBox = driver.FindElement(By.Name("names[last_name]"));
            textBox.SendKeys("Mishra");
            textBox = driver.FindElement(By.Name("email"));
            textBox.SendKeys("deepak123.dm98@gmail.com");
            textBox = driver.FindElement(By.Name("numeric-field"));
            textBox.SendKeys("+918668527346");
            textBox = driver.FindElement(By.Name("message"));
            textBox.SendKeys("Test");
            driver.FindElement(By.XPath("//*[@id=\"fluentform_1\"]/fieldset/div[4]/div[2]/div")).Click();
            driver.FindElement(By.XPath("//*[@id=\"fluentform_1\"]/fieldset/div[6]/button")).Submit();

            Thread.Sleep(5000);
            Console.WriteLine(textBox.GetAttribute("value"));
            Console.WriteLine(textBox.GetAttribute("maxlength"));

            Thread.Sleep(2000);


            driver.Quit();
           

        }

    }
}
