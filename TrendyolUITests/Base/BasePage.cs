using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TrendyolUITests.Base
{
    public class BasePage
    {
        IWebDriver driver;
        WebDriverWait wait;

        public BasePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(60));
        }

        public IWebElement FindElement(By by)
        {
            return driver.FindElement(by);
        }

        public void ClickElement(By by)
        {
            //Sayfanın tam yüklenip test edilmesini sağlar. Aksi halde sayfa geç yüklendiğinde elementler gelmeyeceği için error alabilir.
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
            FindElement(by).Click();
        }

        public void HoverElement(By by)
        {
            IWebElement element;
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();
        }

        public void SendKeys(By by, String text)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
            FindElement(by).SendKeys(text);
        }

        public void Back()
        {
            driver.Navigate().Back();
        }

        public void WaitSeconds(int second)
        {
            Thread.Sleep(TimeSpan.FromSeconds(second));
        }

        public void WaitElementIsVisible(By by)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public string GetText(By by)
        {
            return FindElement(by).Text;
        }

        public bool IsElementVisible(By by, int waitSec)
        {
            IWebElement element = null;
            bool isTrue = false;
            DateTime now = DateTime.Now;
            while ((DateTime.Now.Second - now.Second)< waitSec)
            {
                element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));

                //Check if element visible
                if (!element.Equals(null))
                {
                    isTrue = true;
                    break;
                }
            }

            return isTrue;
        }
    }
}
