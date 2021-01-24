using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TrendyolUITests.Model;
using TrendyolUITests.Util;
using static TrendyolUITests.Constants.ConstantLoginPage;

namespace TrendyolUITests.Test
{
    [Binding, Scope(Feature = "LoginPage")]
    public class LoginPageTest
    {
        [BeforeScenario]
        public void SetUp()
        {
            browser = new Browser();
            webDriver = browser.WebDriver();

            loginPageModel = new LoginPageModel(webDriver);
        }

        [StepDefinition(@"'(.*)' sayfasi acilir")]
        public void GivenSayfasiAcilir(string url)
        {
            browser.Navigate(url);
        }

        [StepDefinition(@"E-Posta alanina '(.*)' girilir")]
        public void SetEmail(string email)
        {
            loginPageModel.SetEmail(email);
        }

        [StepDefinition(@"Şifre alanina '(.*)' girilir")]
        public void SetPassword(string password)
        {
            loginPageModel.SetPassword(password);
        }

        [StepDefinition(@"Giris yap butonuna tiklanir")]
        public void ClickLoginButton()
        {
            loginPageModel.ClickLoginButton();
        }


        [StepDefinition(@"'(.*)' mesaji gorulerek test basarili sonuclanir")]
        public void CheckErrorMessage(string expectedResult)
        {
            Assert.AreEqual(expectedResult, loginPageModel.GetTextMessage(), "Hata mesajı yok");
        }

        [StepDefinition(@"Hesabim geldigi gorulur ve test basarili sonuclanir")]
        public void CheckMyAccountLinkIsVisible()
        {
            Assert.IsTrue(loginPageModel.CheckMyAccountLinkIsVisible(), "Hesaba giriş yapılamadı");
        }


        [AfterScenario]
        public void TearDown()
        {
            webDriver.Quit();
        }
    }
}
