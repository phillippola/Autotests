using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace AutotestsLearning
{
    public class SampleTest
    {
        [Test]
        public void Sample()
        {
            Assert.That(true, Is.True);
        }

        [Test]
        public void FirstSeleniumTest()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.nbc.com");
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
            driver.Quit();
        }

        public class NBCHeader
        {
            public const string lnkShows = "a[href='/shows']";
            public const string lnkEpisodes = "a[href='/video']";
            public const string lnkSchedule = "a[href='/schedule']";
            public const string btnNewsAndSports = "//span[contains(text(), 'Sports')]/..";
            public const string lnkShop = "a[href='https://www.nbcstore.com/?cid=nbc_global_nav_shop']";
            public const string lnkApp = "a[href='/apps']";
            public const string btnSearch = "button.navigation__search.navigation__item__title";
        }
    }
}
