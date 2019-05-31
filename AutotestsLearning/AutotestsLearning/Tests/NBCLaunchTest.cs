using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace AutotestsLearning.Tests
{
    public class NBCLaunchTest
    {
            [Test]
            public void FirstSeleniumTest()
            {
                var driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.nbc.com");
                driver.Manage().Window.Maximize();
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
                driver.Quit();
            }
        }
}
