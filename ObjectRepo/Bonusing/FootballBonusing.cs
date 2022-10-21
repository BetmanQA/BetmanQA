using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AutomationBetMan.BaseClass;
using System.Globalization;

//extent report imports
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

namespace AutomationBetMan.ObjectRepo.FootballObjects.Single 
{
    public class FootballBonusing : BaseTest
    {
        IWebDriver Driver;
        
        public FootballBonusing (IWebDriver driver)
        {
            Driver = driver;
        } 
        
        IWebElement footballGroupIcon => Driver.FindElement(By.Id("FootballGroup")); 
        IWebElement englishSingleMatch => Driver.FindElement(By.Id("EnglishFastLeagueFootballSingleMatch"));

        //"Group" of single bet odd selection
        IWebElement xMROdd1 => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[3]/div[2]/div/div[2]/div/div[9]/div/div/div[2]/div/div[1]/div/div[1]/div/span"));
        IWebElement xMROdd2 => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[3]/div[2]/div/div[2]/div/div[9]/div/div/div[2]/div/div[1]/div/div[2]/div/span"));
        IWebElement xMROdd3 => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[3]/div[2]/div/div[2]/div/div[9]/div/div/div[2]/div/div[1]/div/div[3]/div/span"));
        IWebElement bet1Odd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[1]/div[1]/div[1]/div[1]/h3[2]/span[2]"));
        IWebElement bet2Odd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[1]/div[1]/div[2]/div[1]/h3[2]/span[2]"));
        IWebElement bet3Odd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[1]/div[1]/div[3]/div[1]/h3[2]/span[2]"));
        IWebElement totStake => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/div[3]/div/div[2]/table/tbody/tr[1]/td[2]/h4/span"));
        IWebElement maxBonus => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/div[3]/div/div[2]/table/tbody/tr[2]/td[2]/h4/span"));
        IWebElement totToWin => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/div[3]/div/div[2]/table/tbody/tr[2]/td[2]/h4/span"));
        //IWebElement firstAvailableDenominator => Driver.FindElement(By.Name("CurrencySymbol"));
        IWebElement manualStakeEdit => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/div[3]/div/div[1]/div/div[2]/i"));
        IWebElement submitBetSlip => Driver.FindElement(By.Id("submit-bet-slip"));

        //Group of Multiple bet odds
        IWebElement bonusMessage => Driver.FindElement(By.Id("multiple-bonus-message"));
        IWebElement event1Odd1 => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[3]/div[2]/div/div[2]/div/div[7]/div/div/div[2]/div/div[1]/div/div[1]/div/span"));
        IWebElement event1Odd2 => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[3]/div[2]/div/div[2]/div/div[7]/div/div/div[2]/div/div[1]/div/div[2]/div/span"));
        IWebElement event2Odd1 => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[3]/div[2]/div/div[2]/div/div[9]/div/div/div[2]/div/div[1]/div/div[1]/div/span"));
        IWebElement event2Odd2 => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[3]/div[2]/div/div[2]/div/div[9]/div/div/div[2]/div/div[1]/div/div[2]/div/span"));
        IWebElement betslipOdd1 => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[2]/div[1]/div[1]/div[1]/h3[2]/span[2]"));
        IWebElement betslipOdd2 => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[2]/div[1]/div[2]/div[1]/h3[2]/span[2]"));
        IWebElement betslipOdd3 => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[2]/div[1]/div[3]/div[1]/h3[2]/span[2]"));
        IWebElement betslipOdd4 => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[2]/div[1]/div[4]/div[1]/h3[2]/span[2]"));
        IWebElement MultiBetStakeEdit => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[2]/div[2]/div[3]/div/div/div[2]/i"));
        IWebElement MultiBetMaxBonus => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[2]/div[2]/div[4]/table/tbody/tr[2]/td[2]/h4/span"));
        IWebElement MultiBetTotToWin => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[2]/div[2]/div[4]/table/tbody/tr[3]/td[2]/h4/span"));
        //Functions
        public void PlaceSinglebetBonusing()
        {
            //add wait line
            Thread.Sleep(3000);
            footballGroupIcon.Click();
            Thread.Sleep(3000);
            englishSingleMatch.Click();
            Thread.Sleep(3000);
            xMROdd1.Click();
            Thread.Sleep(2000);
            xMROdd2.Click();
            Thread.Sleep(2000);
            xMROdd3.Click();
            Thread.Sleep(2000);
            for (int i=1; i<=100; i++) {
            manualStakeEdit.Click();
            }


            const int stake = 100;
            var A = bet1Odd.Text;
            var B = bet2Odd.Text;
            var C = bet3Odd.Text;
            var D = totStake.Text;
            var E = maxBonus.Text;
            var F = totToWin.Text;
         
          //convert text to double
            NumberFormatInfo numFormat = new NumberFormatInfo();
          //  numFormat.NumberDecimalSeparator = ",";
          //  numFormat.NumberGroupSeparator = ".";

            double mROdds1,mROdds2,mROdds3;


            mROdds1 = Convert.ToDouble(A, numFormat);
            mROdds2 = Convert.ToDouble(B, numFormat);
            mROdds3 = Convert.ToDouble(C, numFormat);

            //calculate ToWin amount for each bet
            var winAmntA = mROdds1*stake;
            var winAmntB = mROdds2*stake;
            var winAmntC = mROdds3*stake;
            //calculate Max Bonus, Total Stake & Total To Win values 
            var maxBonusCalc = (winAmntA+winAmntB+winAmntC)/100*10;
            var totWinToWinCalc = winAmntA+winAmntB+winAmntC+maxBonusCalc;

            Console.WriteLine("Bet1 Odds:" + A);
            Console.WriteLine("Bet2 Odds:" + B);
            Console.WriteLine("Bet3 Odds:" + C);
            Console.WriteLine("Total Stake Amount:" + D);
            Console.WriteLine("To win amount for first bet:" + winAmntA);
            Console.WriteLine("To win amount for second bet:" + winAmntB);
            Console.WriteLine("To win amount for third bet:" + winAmntC);
            Console.WriteLine("Total To Win amount:" + totWinToWinCalc);
            Console.WriteLine("Max bonus amount:" + maxBonusCalc);
            /*if (totWinToWinCalc.Equals(F)){
                Console.WriteLine("Win Amount calculated correctly");
            }
            else{
                Console.WriteLine("Potential Winnings NOT calculated correctly");
            }*/
            Thread.Sleep(2000);
            submitBetSlip.Click();
        }
        
        public void PlaceMultiplebet()
        {
            //add wait line
            Thread.Sleep(5000);
            footballGroupIcon.Click();
            Thread.Sleep(5000);
            englishSingleMatch.Click();
            Thread.Sleep(5000);
            event1Odd1.Click();
            Thread.Sleep(2000);
            event1Odd2.Click();
            Thread.Sleep(2000);
            event2Odd1.Click();
            Thread.Sleep(2000);
            event2Odd2.Click();
            Thread.Sleep(2000);

            for (int i=1; i<=100; i++) {
            MultiBetStakeEdit.Click();
            }
            var AA = betslipOdd1.Text;
            var BB = betslipOdd2.Text;
            var CC = betslipOdd3.Text;
            var DD = betslipOdd4.Text;
            var EE = MultiBetMaxBonus.Text;
            var FF = MultiBetTotToWin.Text;

            NumberFormatInfo numFormat = new NumberFormatInfo();
            //numFormat.NumberDecimalSeparator = ",";
            //numFormat.NumberGroupSeparator = ".";

            double slipOdd1,slipOdd2,slipOdd3,slipOdd4;
            //double mxBonus;
            //double stakeTotal;
            //double toWinTotal;
            slipOdd1 = Convert.ToDouble(AA, numFormat);
            slipOdd2 = Convert.ToDouble(BB, numFormat);
            slipOdd3 = Convert.ToDouble(CC, numFormat);
            slipOdd4 = Convert.ToDouble(DD, numFormat);

            var stakeVal = 100;
            var permStake = stakeVal/4;
            //Bonus is configured at 10% for the game
            var bonusPercentage = 0.1;
            //Max Odds 
            var maxOddsbet1And3 = slipOdd1*slipOdd3;
            var maxOddsbet1And4 = slipOdd1*slipOdd4;
            var maxOddsbet2And3 = slipOdd2*slipOdd3;
            var maxOddsbet2And4 = slipOdd2*slipOdd4;
            //Potential Winnings 
            var bet1And3PW = maxOddsbet1And3*permStake;
            var bet1And4PW = maxOddsbet1And4*permStake;
            var bet2And3PW = maxOddsbet2And3*permStake;
            var bet2And4PW = maxOddsbet2And4*permStake;
            //Bonus Winnings
            var bet1And3Bonus = bet1And3PW*bonusPercentage;
            var bet1And4Bonus = bet1And4PW*bonusPercentage;
            var bet2And3Bonus = bet2And3PW*bonusPercentage;
            var bet2And4Bonus = bet2And4PW*bonusPercentage;
            //Total Bonus Winnings
            var multiMaxBonus=bet1And3Bonus+bet1And4Bonus+bet2And3Bonus+bet2And4Bonus;
            //Total To Win amount
            var multiPotWinnings=bet1And3PW+bet1And4PW+bet2And3PW+bet2And4PW+multiMaxBonus;

            Console.WriteLine(slipOdd1);
            Console.WriteLine(slipOdd2);
            Console.WriteLine(slipOdd3);
            Console.WriteLine(slipOdd4);

            Console.WriteLine("Bet 1 & 3 max odds:" + maxOddsbet1And3);
            Console.WriteLine("Bet 1 & 4 max odds:" + maxOddsbet1And4);
            Console.WriteLine("Bet 2 & 3 max odds:" + maxOddsbet2And3);
            Console.WriteLine("Bet 2 & 4 max odds:" + maxOddsbet2And4);

            Console.WriteLine("Bet 1 & 3 Potential Winnings:" + bet1And3PW);
            Console.WriteLine("Bet 1 & 4 Potential Winnings:" + bet1And4PW);
            Console.WriteLine("Bet 2 & 3 Potential Winnings:" + bet2And3PW);
            Console.WriteLine("Bet 2 & 4 Potential Winnings:" + bet2And4PW);

            Console.WriteLine(EE);
            Console.WriteLine("Max Bonus Winnings:" + multiMaxBonus);
            
            Console.WriteLine(FF);
            Console.WriteLine("Potential Winnings for all legs:" + multiPotWinnings);
            submitBetSlip.Click();
        }
    }
}