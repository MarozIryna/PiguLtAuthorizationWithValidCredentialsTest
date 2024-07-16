using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationPiguPageTests.PageObjects
{
    internal class MainMenuPageObject
    {
        private readonly IWebDriver driver;

        private readonly By _closeCookies = By.XPath("//*[@id='consent_block']/div/div[2]/div[2]/button[1]");
        private readonly By _loginButton = By.XPath("//*[@id='headeMenu']/li[1]/a/i");

        public MainMenuPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void CloseCookies()
        {
            driver.FindElement(_closeCookies).Click();
            System.Threading.Thread.Sleep(1000);
        }

        public void LogIn()
        {
            driver.FindElement(_loginButton).Click();
        }

        private readonly By _signInButton = By.XPath("//*[@id='headeMenu']/li[1]/div/div/div[2]/a[1]");
        private readonly By _loginInputButton = By.XPath("//*[@id='email']");
        private readonly By _passwordInputButton = By.XPath("//*[@id='password']");
        private readonly By _submitButton = By.XPath("//*[@id='submitButton']");

        public void SingIn(string _login, string _password)
        {
            driver.FindElement(_signInButton).Click();
            driver.FindElement(_loginInputButton).SendKeys(UserNameForTest.StartLogin);
            driver.FindElement(_passwordInputButton).SendKeys(UserNameForTest.StartLoginPassword);
            driver.FindElement(_submitButton).Click();

        }
    }
}
