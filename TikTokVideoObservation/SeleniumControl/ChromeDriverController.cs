using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Net.Http.Headers;

namespace SeleniumControl
{
    public class ChromeDriverController : IDisposable
    {
        public TimeSpan TimeSpan { get; set; } = TimeSpan.FromSeconds(60);
        public ChromeDriver Driver { get;set; }
        public ChromeDriverController()
        {
            Driver = new ChromeDriver(Properties.Resources.ChromeDriverPath, GetOptions());
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan;
        }
        public ChromeDriverController(ChromeDriver driver):this()
        {
            this.Driver = driver;
        }
        ~ChromeDriverController()
        {
            Dispose();
        }
        private ChromeOptions GetOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument($"--user-data-dir={Properties.Resources.UserDataDir}");
            options.AddArgument($"--profile-directory={Properties.Resources.ProfileDirectory}");
            options.AddArgument($"--lang={Properties.Resources.Lang}");
            //options.AddArgument("--headless");

            return options;
        }
        public void GotoUrl(string url)
        {
            // サイトを表示する
            Driver.Navigate().GoToUrl(url);
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}