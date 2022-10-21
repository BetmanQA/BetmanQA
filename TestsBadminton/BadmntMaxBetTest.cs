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

namespace AutomationBetMan.TestCases
{
    [TestFixture]
    public class BadmntnMultiMaxBet : BaseTest
    {
        [Test]
        public void PlaceBadmintonMutliBet()
        {
            var MultiMaxBet = new PlaceBetBadminton(driver);
            MultiMaxBet.BadmntnMultiMaxBets();
            Thread.Sleep(2000);
        }
    }
}
