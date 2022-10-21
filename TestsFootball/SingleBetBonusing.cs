using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using SeleniumCSharpNetCore.Pages;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System.Reflection;
using AutomationBetMan.BaseClass;
using AutomationBetMan.ObjectRepo.FootballObjects.Single;
using System.Threading;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;


namespace AutomationBetMan.TestCases
{
    [TestFixture]
    public class singleGameBonusTest : BaseTest
    {
        [Test]
        public void PlaceSinglebetBonusingBet()
        {
            var SingleGameBonus = new FootballBonusing(driver);
            SingleGameBonus.PlaceSinglebetBonusing();
            System.Threading.Thread.Sleep(2000);

           /* var htmlReporter = new ExtentHtmlReporter("extentReport.html");
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Operating System", "Win 10");
            extent.AddSystemInfo("Browser:", "Google Chrome");
            var test = extent.CreateTest("envVariable");
            test.Log(Status.Info, "Step 1 : Test case starts");
            test.Log(Status.Info, "Step: 1 Test case passed");
            extent.Flush();*/
            

         
        }

    }
}