using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Guru99
{
    class Guru99Demo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {

            var chromeOptions = new ChromeOptions();
            //string[] s_1 = new string[2];
           // s_1[0] = "enable-webgl-image-chromium";
            //s_1[1] = "gpu";
          //  s_1[2] = "no-startup-window";
           // s_1[3] = "silent-launch";
           // s_1[4] = "mute-audio";
          //  s_1[5] = "silent-launch";
            //s_1.Append("--headless");
            //s_1.Append("--use-gl");
            //s_1.Append("--add-gpu-appcontainer-caps");
            //s_1.Append("--enable-webgl-swap-chain");
            //s_1.Append("--enable-webgl2-compute-context");
            //s_1.Append("--enable-webgl2-compute-context");
          //  Console.WriteLine(s_1.Length);
            //chromeOptions.AddArguments(s_1);
            //chromeOptions.AddArgument("--headless");
            //chromeOptions.AddArgument("--use-gl");
            //chromeOptions.AddArgument("--add-gpu-appcontainer-caps");
            //chromeOptions.AddArgument("--enable-webgl-image-chromium");
            //chromeOptions.AddArgument("--enable-webgl-swap-chain");
            //chromeOptions.AddArgument("--enable-webgl-draft-extensions");
            //chromeOptions.AddArgument("--enable-webgl2-compute-context");--disable-gpu

            Console.WriteLine(chromeOptions.Arguments.Count + "adsadsada");
            chromeOptions.AddUserProfilePreference("download.default_directory", @"D:\Users\Administrator\source\repos\Guru_client\");
            chromeOptions.AddUserProfilePreference("intl.accept_languages", "nl");
            chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
          //  chromeOptions.AddUserProfilePreference("--disable-gpu", "false");
          //  chromeOptions.AddUserProfilePreference("headless","false");

            driver = new ChromeDriver("D:\\Users\\Administrator\\source\\repos\\Guru99\\", chromeOptions);
            
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void test(string c_str,string s_str,string name,string degree)
        {
            //D:\GIT\TRANSFROMTEST\img绝对路径
            //driver.Url = "http://localhost:9966/ ";
            //SelectElement select_c = new SelectElement(driver.FindElement(By.Id("content-select")));
            //select_c.SelectByIndex(4);
            //SelectElement select_s = new SelectElement(driver.FindElement(By.Id("style-select")));
            ////select_s.SelectByIndex(4);
            //string c_str_v = c_str;
            //string s_str_v = s_str;
            // images / diana.jpg + "images/red_circles.jpg"


            //((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            //driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Url = "http://localhost:9966/?c_src="+c_str+"&s_src="+s_str+ "&name=" + name + "&degree=" + degree;


            Console.WriteLine(driver.Url);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
        

    }
}
