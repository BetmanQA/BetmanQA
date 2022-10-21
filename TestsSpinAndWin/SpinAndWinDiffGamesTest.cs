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
    public class SpinAndWinDiffGames : BaseTest
    {
        [Test]
        public void SpinAndWinPlaceBet()
        {
            var placeBetsSW = new SpinAndWinAll(driver);
            placeBetsSW.placeBetsDifferentGames();

            Thread.Sleep(2000);
        }
    }
}
