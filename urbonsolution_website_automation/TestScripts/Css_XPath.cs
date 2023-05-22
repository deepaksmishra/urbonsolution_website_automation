using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using static urbonsolution_website_automation.GlobalMessage.Message;

namespace urbonsolution_website_automation.Test
{
    internal class Css_XPath
    {
        static void Main(string[] args)
        {


            string xpath = "//*[@id=\"ff_1_names_first_name_\"]";
            string csspath = "#site-footer > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-3b5a7c5a.elementor-section-content-middle.ot-traditional.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div > div > div > h3";
            string url = "https://www.urbonsolution.com/contacts/";


            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            IWebElement csspathelement;
            IWebElement xpathelement = driver.FindElement(By.XPath(xpath));
            try
            {
             csspathelement = driver.FindElement(By.CssSelector(csspath));

                if (csspathelement.Displayed)
                {
                    SucessMessage("Element by css path Found successfully!!!");

                }
            }
            catch (InvalidSelectorException)
            {

                FailMessage("Element Not Found by css path ");

            }


        }
    }

}