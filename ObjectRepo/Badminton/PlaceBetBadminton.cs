using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AutomationBetMan.BaseClass;
using NUnit.Framework;
//extent report imports
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using System.Globalization;

namespace AutomationBetMan.ObjectRepo.FootballObjects.Single 
{
    public class PlaceBetBadminton : BaseTest
    {
        IWebDriver Driver;
        
        public PlaceBetBadminton (IWebDriver driver)
        {
            Driver = driver;
        } 
        
        IWebElement badmintonIcon => Driver.FindElement(By.Id("Badminton")); 
        //Exapnd markets
        IWebElement expadMarkets => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[11]/i"));
        //Exapnd markets and place a bet in each market
        //IWebElement expadMatchResults => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[1]/i"));
         IWebElement expadMatchResults => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[1]/i"));
        IWebElement matchResultA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[1]/div/div/div[1]/div/span"));
        //IWebElement matchResultA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[6]/section/div/div/div[1]/div/div/div[1]/div/span"));
        //IWebElement winPointsHighOrLow => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[6]/section/div/div/div[2]/div/div/div[2]/div/span"));
        IWebElement winPointsHighOrLow => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[2]/i"));
         
        IWebElement manualStakeEdit => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/div[3]/div/div[1]/div/div[2]/i"));
        IWebElement winPointsHLA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[2]/div/div/div[2]/div/span"));
        IWebElement MatchROdd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[1]/div[1]/div/div[1]/h3[2]/span[2]"));
        IWebElement WinPointsHLOd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[1]/div[1]/div[2]/div[1]/h3[2]/span[2]"));
        IWebElement toWin => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/div[3]/div/div[2]/table/tbody/tr[3]/td[2]/h4/span"));
        IWebElement correctScore => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[3]/i"));
        IWebElement correctScoreA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[3]/div/div/div[1]/div/span"));
        IWebElement totalPoints => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[4]/i"));
        IWebElement totalPointsB => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[4]/div/div/div[2]/div/span"));
        IWebElement longestConsPoints => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[5]/i"));
        IWebElement longestConsPntsA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[5]/div/div/div[1]/div/span"));
        IWebElement firstToScoreA => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[6]/i"));
        IWebElement firstToScore17B => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[6]/div/div/div[2]/div/span"));
        IWebElement firstToScoreB => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[7]/i"));
        IWebElement firstToScore137A => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[7]/div/div/div[1]/div/span"));
        IWebElement totalPointsOEHL => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/button[8]/i"));
        IWebElement totPointsOEHLB => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[12]/section/div/div/div[8]/div/div/div[2]/div/span"));
        IWebElement firstAvailableDenominator => Driver.FindElement(By.Name("CurrencySymbol"));
        IWebElement submitBetSlip => Driver.FindElement(By.Id("submit-bet-slip"));

        //2nd event Objects - For multiple bet
        IWebElement expandMarketsB => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[9]/i"));
        IWebElement CorrectScore => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[10]/section/div/div/button[3]/i")); 
        IWebElement SelectionOne => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[10]/section/div/div/div[3]/div/div/div[1]/div/span"));
        IWebElement SelectionFour => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[10]/section/div/div/div[3]/div/div/div[2]/div/span"));
        IWebElement SelectionTen => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[9]/div[2]/div/div[2]/div/div[10]/section/div/div/div[3]/div/div/div[10]/div"));
        IWebElement MultiBetStakeEdit => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[2]/div[2]/div[3]/div/div/div[2]/i"));
        IWebElement lblMAxAllowedBets => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/div[4]/div"));
        //Football Objects - for multiple bet
        IWebElement footballGroupIcon => Driver.FindElement(By.Id("FootballGroup")); 
        IWebElement spanishSingleMatch => Driver.FindElement(By.Id("SpanishFastLeagueFootballSingleMatch"));
        IWebElement xMROdd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[6]/div[2]/div/div[2]/div/div[5]/div/div/div[2]/div/div[1]/div/div[2]/div/span"));

    // Function #1: Place Single bets on all available markets for Badminton
        public void PlaceSinglebetsAllMarkets()
        {
            //add wait line
            Thread.Sleep(5000);
            badmintonIcon.Click();
            Thread.Sleep(5000);
            expadMarkets.Click();
            Thread.Sleep(2000);
            expadMatchResults.Click();
            Thread.Sleep(2000);
            matchResultA.Click();
            Thread.Sleep(2000);
            winPointsHighOrLow.Click();
            Thread.Sleep(2000);
            winPointsHLA.Click();
            Thread.Sleep(2000);
            correctScore.Click();
            Thread.Sleep(2000);
            correctScoreA.Click();
            Thread.Sleep(2000);
            totalPoints.Click();
            Thread.Sleep(2000);
            totalPointsB.Click();
            Thread.Sleep(2000);
            longestConsPoints.Click();
            Thread.Sleep(2000);
            longestConsPntsA.Click();
            Thread.Sleep(2000);
            firstToScoreA.Click();
            Thread.Sleep(2000);
            firstToScore17B.Click();
            Thread.Sleep(2000);
            firstToScoreB.Click();
            Thread.Sleep(2000);
            firstToScore137A.Click();
            Thread.Sleep(2000);
            totalPointsOEHL.Click();
            Thread.Sleep(2000);
            totPointsOEHLB.Click();
            Thread.Sleep(5000);
            firstAvailableDenominator.Click();
            Thread.Sleep(2000);
            for (int i=1; i<=20; i++) {
            manualStakeEdit.Click();
            }
            submitBetSlip.Click();
        }
    // Function #2: Place multiple bets on Badminton
        public void PlaceMultiBetSameGame()
        {
            //1st event
            Thread.Sleep(2000);
            badmintonIcon.Click();
            Thread.Sleep(2000);
            expadMarkets.Click();
            Thread.Sleep(2000);
            expadMatchResults.Click();
            Thread.Sleep(2000);
            matchResultA.Click();
            Thread.Sleep(2000);
            winPointsHighOrLow.Click();
            Thread.Sleep(2000);
            winPointsHLA.Click();
            Thread.Sleep(2000);
            //2nd event
            expandMarketsB.Click();
            Thread.Sleep(2000);
            CorrectScore.Click();
            Thread.Sleep(1000);
            SelectionOne.Click();
            Thread.Sleep(2000);
            SelectionFour.Click();
            Thread.Sleep(2000);
           // xMROdd.Click();
            for (int i=1; i<=20; i++) {
            MultiBetStakeEdit.Click();
            }
            Thread.Sleep(10000);
            submitBetSlip.Click();

            //manualStakeEdit.Click();
            Thread.Sleep(5000);
            submitBetSlip.Click();

    // Function #3: Place multiple bets on Badminton and Football

    }
        public void PlaceMultiBetDiffGames()
        {
            //For Badminton
            Thread.Sleep(2000);
            badmintonIcon.Click();
            Thread.Sleep(2000);
            expadMarkets.Click();
            Thread.Sleep(2000);
            expadMatchResults.Click();
            Thread.Sleep(2000);
            matchResultA.Click();
            Thread.Sleep(2000);
            winPointsHighOrLow.Click();
            Thread.Sleep(2000);
            winPointsHLA.Click();
            Thread.Sleep(2000);
            //For football
            Thread.Sleep(10000);
            footballGroupIcon.Click();
            Thread.Sleep(10000);
            spanishSingleMatch.Click();
            Thread.Sleep(10000);
            xMROdd.Click();
            for (int i=1; i<=20; i++) {
            MultiBetStakeEdit.Click();
            }
            Thread.Sleep(10000);
            submitBetSlip.Click();

            //manualStakeEdit.Click();
            Thread.Sleep(5000);
            submitBetSlip.Click();

   
        }

    // Function #4: Calculate the To Win Amount for a single bet
 public void BadmntnSinglebetCalcs()
        {
            //add wait line
            Thread.Sleep(5000);
            badmintonIcon.Click();
            Thread.Sleep(2000);
            expadMarkets.Click();
            Thread.Sleep(2000);
            expadMatchResults.Click();
            Thread.Sleep(2000);
            matchResultA.Click();
            Thread.Sleep(2000);
            winPointsHighOrLow.Click();
            Thread.Sleep(2000);
            winPointsHLA.Click();
            Thread.Sleep(2000);
            for (int i=1; i<=100; i++) {
            manualStakeEdit.Click();
            }
             
            const int stake = 100;
            var A = MatchROdd.Text;
            var B = WinPointsHLOd.Text;
            var C = toWin.Text;
          //convert text to double
            NumberFormatInfo numFormat = new NumberFormatInfo();
            //numFormat.NumberDecimalSeparator = ",";
            numFormat.NumberGroupSeparator = ".";

            double mROdds;
            double wPHLOdds;
            mROdds = Convert.ToDouble(A, numFormat);
            wPHLOdds = Convert.ToDouble(B, numFormat);
            var winAmntA = mROdds*stake;
            var winAmntB = wPHLOdds*stake;
            var totWinToWin = winAmntA+winAmntB;

            Console.WriteLine("Bet1 Odds:" + A);
            Console.WriteLine("Bet2 Odds:" + B);
            Console.WriteLine(C);
            Console.WriteLine("To win amount for first bet:" + winAmntA);
            Console.WriteLine("To win amount for second bet:" + winAmntB);
            Console.WriteLine("Total To Win amount:" + totWinToWin);
            Thread.Sleep(2000);
            submitBetSlip.Click();
        }


 // Function #5: Maximum number of bets for multiple bets
 public void BadmntnMultiMaxBets()
        {
            //add wait line
            Thread.Sleep(5000);
            badmintonIcon.Click();
            Thread.Sleep(5000);
            expadMarkets.Click();
            Thread.Sleep(2000);
            expadMatchResults.Click();
            Thread.Sleep(2000);
            matchResultA.Click();
            Thread.Sleep(2000);
            winPointsHighOrLow.Click();
            Thread.Sleep(2000);
            winPointsHLA.Click();
            Thread.Sleep(2000);
            correctScore.Click();
            Thread.Sleep(2000);
            correctScoreA.Click();
            Thread.Sleep(2000);
            totalPoints.Click();
            Thread.Sleep(2000);
            totalPointsB.Click();
            Thread.Sleep(2000);
            longestConsPoints.Click();
            Thread.Sleep(2000);
            longestConsPntsA.Click();
            Thread.Sleep(2000);
            firstToScoreA.Click();
            Thread.Sleep(2000);
            firstToScore17B.Click();
            Thread.Sleep(2000);
            firstToScoreB.Click();
            Thread.Sleep(2000);
            firstToScore137A.Click();
            Thread.Sleep(2000);
            totalPointsOEHL.Click();
            Thread.Sleep(2000);
            totPointsOEHLB.Click();
            Thread.Sleep(2000);
            //scroll to the top of the page
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollTo(0, -200)");
            Thread.Sleep(3000);
            expandMarketsB.Click();
            Thread.Sleep(2000);
            CorrectScore.Click();
            Thread.Sleep(1000);
            SelectionOne.Click();
            Thread.Sleep(2000);
            SelectionFour.Click();
            Thread.Sleep(2000);
           // SelectionTen.Click();
            //Thread.Sleep(2000);
            if (lblMAxAllowedBets.Displayed){
                Console.WriteLine("Maximum Bet error was displayed");
            }
            for (int i=1; i<=5; i++) {
            MultiBetStakeEdit.Click();
            }
             

            Thread.Sleep(2000);
            submitBetSlip.Click();
        }



 }
}