using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrendyolUITests.Util
{
    public class Browser
    {
        IWebDriver webDriver;

        public IWebDriver WebDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            options.AddArguments("--disable-infobars");
            options.AddArguments("--disable-notifications");
            options.AddArguments("enable-automation");
            webDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);

            return webDriver;
        }

        public void Navigate(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        public void Back(IWebDriver driver)
        {
            driver.Navigate().Back();
        }
    }
}
