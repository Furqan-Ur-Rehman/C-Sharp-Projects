﻿
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V111.Debugger;
using static System.Net.Mime.MediaTypeNames;


namespace Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.youtube.com/");

            var searchbars = driver.FindElements(By.Id("search"));

            foreach (var searchbar in searchbars)
            {
                var searchbarfinal = searchbar.GetAttribute("placeholder");

                if (searchbarfinal == "Search")
                {
                    searchbar.SendKeys("Learning Never Ends");
                    var searchbtn = driver.FindElements(By.Id("search-icon-legacy"));
                    if (searchbtn.Count != 0)
                    {
                        searchbtn[0].Click();
                    }
                    break;
                }
            }
            System.Threading.Thread.Sleep(5000);
            var channels = driver.FindElements(By.Id("text"));
            foreach (var channel in channels)
            {
                var name = channel.GetAttribute("innerHTML");
                if (name == "Learning Never Ends")
                {
                    channel.Click();
                    break;
                }
            }
            System.Threading.Thread.Sleep(5000);

            var Videobtns = driver.FindElements(By.CssSelector(".tab-title .style-scope .ytd-c4-tabbed-header-renderer"));
            foreach (var Videobtn in Videobtns)
            {
                var btnname = Videobtn.GetAttribute("Text");
                Console.WriteLine(btnname);
                if (btnname == "Videos")
                {
                    Videobtn.Click();
                }
            }
        }
    }
}

