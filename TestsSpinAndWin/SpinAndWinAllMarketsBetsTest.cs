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

namespace AutomationBetMan.ObjectRepo.SpinAndWin
{
    [TestFixture]
    public class SpinAndWin : BaseTest
    {
        [Test]
        public void SpinAndWinAllMarketsBets()
        {
            var allMarketsBets = new SpinAndWinAll(driver);
            allMarketsBets.PlaceAllMarketBetsSW();
            Thread.Sleep(2000);
        }
    }
}
