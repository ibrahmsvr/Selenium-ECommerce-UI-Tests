using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolUITests.Model;
using TrendyolUITests.Util;

namespace TrendyolUITests.Constants
{
    public static class ConstantLoginPage
    {
        public static IWebDriver webDriver;
        public static Browser browser = new Browser();
        public static LoginPageModel loginPageModel; 

        public static By txtEmail = By.Id("login-email");
        public static By txtPassword = By.Id("login-password-input");
        public static By lblMessage = By.XPath("//*[@id='error-box-wrapper']/span[2]");
        public static By btnLogin = By.XPath("//*[@id='login-register']//form/button");
    }
}
