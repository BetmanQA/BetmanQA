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
    public class BadmntnMultipleBetSameEevntType : BaseTest
    {
        [Test]
        public void MultiBetBadminton()
        {

            
            var MultiBetBadmintonSame = new PlaceBetBadminton(driver);
            MultiBetBadmintonSame.PlaceMultiBetSameGame();
            Thread.Sleep(2000);
        }
    }

    
}
