using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolUITests.Base;
using static TrendyolUITests.Constants.ConstantLoginPage;

namespace TrendyolUITests.Model
{
    public class LoginPageModel : BasePage
    {
        public LoginPageModel(IWebDriver driver) : base(driver)
        {
            webDriver = driver;
        }

        public void SetEmail(string email)
        {
            SendKeys(txtEmail, email);
        }

        public void SetPassword(string password)
        {
            SendKeys(txtPassword, password);
        }

        public string GetTextMessage()
        {
            IsElementVisible(lblMessage, 5);
            return GetText(lblMessage);
        }

        public void ClickLoginButton()
        {
            ClickElement(btnLogin);
        }

        public bool CheckMyAccountLinkIsVisible()
        {
            WaitSeconds(3);
            string text = GetText(lnkMyAccount); //Hesabım olmalı
            return IsElementVisible(lnkMyAccount, 20);          
        }
    }
}
