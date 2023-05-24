using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace urbonsolution_website_automation.Navigation
{ 
class NavigationLinkTest
    {
        static void Main()
        {
            // Set up the Selenium WebDriver
            IWebDriver driver = new ChromeDriver();

            // Navigate to the webpage
            driver.Navigate().GoToUrl("https://www.urbonsolution.com/");

            // Find all the navigation links on the page
            var navigationLinks = driver.FindElements(By.CssSelector("#menu-main-menu > li.menu-item.menu-item-type-custom.menu-item-object-custom.menu-item-has-children.menu-item-2030 > ul > li > a"));

            // Iterate through each link and test navigation
            foreach (var link in navigationLinks)
            {
                // Get the link's URL
                string linkUrl = link.GetAttribute("href");

                // Click the link
                link.Click();

                // Get the current URL after navigation
                string currentUrl = driver.Url;

                // Check if the navigation was successful
                if (currentUrl == linkUrl)
                {
                    Console.WriteLine($"Navigation to {linkUrl} was successful!");
                }
                else
                {
                    Console.WriteLine($"Navigation to {linkUrl} failed. Current URL: {currentUrl}");
                }

                // Navigate back to the original page
                driver.Navigate().Back();
            }

            // Quit the WebDriver
            driver.Quit();
        }
    }

}
