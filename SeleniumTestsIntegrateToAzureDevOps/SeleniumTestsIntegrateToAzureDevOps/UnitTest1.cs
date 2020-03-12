using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestsIntegrateToAzureDevOps
{
    public class Tests
    {

        IWebDriver driver;
        string url = "https://www.google.se";


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
        }


        [Test]
        public void test1()
        {
            IWebElement searchBox = driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));
            searchBox.SendKeys("if");
            IWebElement button = driver.FindElement(By.ClassName("gNO89b"));
            button.Click();

            //Assert.Pass();
        }


        [TearDown]
        public void tearDown()
        {
            driver.Quit();
        }
    }
}