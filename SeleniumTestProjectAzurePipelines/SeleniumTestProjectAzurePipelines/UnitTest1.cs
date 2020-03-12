using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestProjectAzurePipelines
{
    [TestFixture]
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
            Assert.Pass();
        }
    }
}