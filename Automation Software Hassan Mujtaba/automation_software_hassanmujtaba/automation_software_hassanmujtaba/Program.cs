using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V109.Debugger;
using static System.Net.Mime.MediaTypeNames;

namespace automation_software_hassanmujtaba
{
    internal class Program
    {
        public static IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            driver.Navigate().GoToUrl("https://vulms.vu.edu.pk/");
            System.Threading.Thread.Sleep(2000);
            Login();
        }
        public static void Login()
        {
            var StudentID = driver.FindElement(By.Id("txtStudentID"));
            var StudentPassword = driver.FindElement(By.Id("txtPassword"));

            string MyID = "";
            string MyPassword = "";

            StudentID.SendKeys(MyID);
            StudentPassword.SendKeys(MyPassword);

            driver.FindElement(By.Id("ibtnLogin")).Click();

            System.Threading.Thread.Sleep(1000);

            //Cheking if logined or not
            var StudenIDinput = driver.FindElements(By.Id("txtStudentID"));

            if (StudenIDinput.Count == 0)
            {
                Console.WriteLine("Sucessfully Logined");
                System.Threading.Thread.Sleep(5000);
                OpenCourse();
            }
            else
            {
                Console.WriteLine("Login Attemp faild! Retrying");
                Login();
            }
        }

        public static void OpenCourse()
        {
            var CourseContainer = driver.FindElement(By.Id("MainContent_divCourseList"));
            var Coursedivs = CourseContainer.FindElements(By.ClassName("col-lg-6"));

            //Selecting Course
            var courseName = Coursedivs[2].FindElement(By.ClassName("m-portlet__head-text")).GetAttribute("innerHTML").Split("<br>");
            Console.WriteLine("Opening Course: " + courseName[0].Replace(" ", ""));
            Coursedivs[2].FindElement(By.Id("MainContent_gvCourseList_lbtnCurrentLesson_2")).Click();
            ProcessLectures();
        }
        public static void ProcessLectures()
        {
            var VideosTab = driver.FindElement(By.CssSelector(".row.align-items-end"));
            var VideoTabul = VideosTab.FindElement(By.TagName("ul"));
            var Tab = VideoTabul.FindElements(By.TagName("li"));

            int count = 0;

            foreach (var singleTab in Tab)
            {
                var checkforvideo = singleTab.FindElement(By.TagName("a")).GetAttribute("innerHTML");
                if (checkforvideo.Contains("Video"))
                {
                    count++;
                }
            }
            Console.WriteLine(count + " Video Lectures Found");

            //Opening Lecures and Checking for Viewed Status

            var LectureDiv = driver.FindElement(By.ClassName("tab-content"));
            var Lectures = LectureDiv.FindElements(By.ClassName("tab-pane"));

            foreach (var Lecture in Lectures)
            {
                var Main = Lecture.FindElements(By.Id("pnlVideo"));

                if (Main.Count != 0)
                {
                    string Statusofvideo = Main[0].FindElement(By.TagName("span")).GetAttribute("innerHTML");

                    if (Statusofvideo.Contains("Not"))
                    {
                        Console.WriteLine("This Lecture is not Viewed! Viewing Lecture");

                        for (int v = 0; v != 2; v++)
                        {
                            string Statusofcurrentvideo = Main[0].FindElement(By.TagName("span")).GetAttribute("innerHTML");
                            if (Statusofcurrentvideo.Contains("Not"))
                            {
                                v--;
                                Console.WriteLine("Not Vewed Until Now");
                                System.Threading.Thread.Sleep(20000);
                            }
                            else
                            {
                                Console.WriteLine("Lecture is viewed Now Moving to next lecture");
                                driver.FindElement(By.Id("lbtnNextLesson")).Click();
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("This Lecture is Viewed! Moving to Next Lecture");
                        driver.FindElement(By.Id("lbtnNextLesson")).Click();
                    }
                }
            }

        }
    }
}
