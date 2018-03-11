using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
// using OpenQA.Selenium.Opera;

namespace Selenium_AI
{
    class Program
    {
        static string url = "https://eksisozluk.com/giris?returnUrl=https%3A%2F%2Feksisozluk.com%2F";

        static void Main(string[] args)
        {
            var browser = new ChromeDriver();
            browser.Navigate().GoToUrl(url);

            // IWebDriver browser = new OperaDriver(@"C:\Program Files\Opera\operadriver");
            // browser.Url = url;

            var txt_username = browser.FindElement(By.Id("username"));
            txt_username.SendKeys("a1869883@mvrht.net");

            var txt_password = browser.FindElement(By.Id("password"));
            txt_password.SendKeys("Selenium1");

            var btn_login = browser.FindElements(By.TagName("form"))[2];
            btn_login.Submit();

            var txt_search = browser.FindElement(By.Id("search-textbox"));
            txt_search.SendKeys("hello world");

            var btn_search = browser.FindElement(By.Id("search-form"));
            btn_search.Submit();

            var txt_entry = browser.FindElement(By.Id("editbox"));
            txt_entry.SendKeys("i am a simple bot");

            var btn_entry = browser.FindElements(By.TagName("form"))[3];
            btn_entry.Submit();

            browser.Quit();
        }
    }
}