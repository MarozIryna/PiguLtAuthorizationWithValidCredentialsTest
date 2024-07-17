using AuthorizationPiguPageTests.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AuthorizationPiguPageTests
{
    public class Tests
    {
        private IWebDriver driver;

        private readonly By _userLogin = By.XPath("//*[@id='headeMenu']/li[1]/div/div/div/div[2]/p");

        private const string _expectedLogin = "Sveiki, testastest40@gmail.com!";

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://pigu.lt/lt/katalogas");
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(1000);
        }

        [Test]
        public void LoginWithValidCredentials()
        {
            var mainMenu = new MainMenuPageObject(driver);
            mainMenu.CloseCookies();
            mainMenu.LogIn();
            mainMenu.SingIn(UserNameForTest.StartLogin, UserNameForTest.StartLoginPassword);

            var actualLogin = driver.FindElement(_userLogin).Text;
            Assert.AreEqual(_expectedLogin, actualLogin, "Login failed");
        }

        [TearDown]
        public void TearDown() 
        {
            driver.Quit();
        }
    }
}