using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AutomationBetMan.BaseClass;


namespace AutomationBetMan.ObjectRepo.SpinAndWin

{
    public class SpinAndWinAll : BaseTest
    {
        IWebDriver Driver;
        
        public SpinAndWinAll (IWebDriver driver)
        {
            Driver = driver;
        } 
        //Objects for all markets
        IWebElement spinAndWinIcon => Driver.FindElement(By.Id("SpinAndWin"));
        IWebElement winMarket => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[10]/div[2]/div/div/div[2]/div[2]/div[1]/div[2]/h3"));
        IWebElement columnMarket => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[10]/div[2]/div/div/div[2]/div[3]/div[2]/h3"));
        IWebElement dozensMarket => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[10]/div[2]/div/div/div[2]/div[2]/div[4]/div[2]/h3"));
        IWebElement colorMarket => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[10]/div[2]/div/div/div[2]/div[2]/div[5]/div[3]/h3"));
        IWebElement oddEvenMarket => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[10]/div[2]/div/div/div[2]/div[2]/div[5]/div[2]/h3"));
        IWebElement highLowMarket => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[10]/div[2]/div/div/div[2]/div[2]/div[5]/div[1]/h3"));
        IWebElement sectorColorMarket => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[10]/div[2]/div/div/div[2]/div[2]/div[6]/div[3]"));
        IWebElement neighboursMarket => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[10]/div[2]/div/div/div[3]/div/div[1]/div/div[10]/h3"));
        IWebElement totalStake => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/div[3]/div/div[2]/table/tbody/tr[1]/td[2]/h4/span"));
        IWebElement totalToWin => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/div[3]/div/div[2]/table/tbody/tr[3]/td[2]/h4/span"));
        IWebElement manualStakeEdit => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/div[3]/div/div[1]/div/div[2]/i"));
        IWebElement submitBetSlip => Driver.FindElement(By.Id("submit-bet-slip"));
        //Keno Objects
        IWebElement kenoMenuIcon => Driver.FindElement(By.Id("SmartPlayKeno")); 
        IWebElement evensOdd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[16]/div[2]/div/div/div/div[1]/div[2]/div[2]/div[2]/span"));

        //Functions
        public void PlaceAllMarketBetsSW()
        {
            spinAndWinIcon.Click();
            Thread.Sleep(1000);
            winMarket.Click();
            Thread.Sleep(1000);
            columnMarket.Click();
            Thread.Sleep(1000);
            dozensMarket.Click();
            Thread.Sleep(1000);
            colorMarket.Click();
            Thread.Sleep(1000);
            oddEvenMarket.Click();
            Thread.Sleep(1000);
            highLowMarket.Click();
            Thread.Sleep(1000);
            colorMarket.Click();
            Thread.Sleep(1000);
            sectorColorMarket.Click();
            Thread.Sleep(1000);
            neighboursMarket.Click();
            Thread.Sleep(1000);
            for (int i=1; i<=20; i++) {
            manualStakeEdit.Click();
            }
            submitBetSlip.Click();
            Thread.Sleep(1000);
       
        }

        public void CalcTotalStakeAndToWin()
        {
            spinAndWinIcon.Click();
            Thread.Sleep(5000);
            oddEvenMarket.Click();
            Thread.Sleep(3000);
            highLowMarket.Click();
            Thread.Sleep(1000);
            neighboursMarket.Click();
            Thread.Sleep(1000);
            for (int i=1; i<=50; i++) {
            manualStakeEdit.Click();
            }
            Thread.Sleep(2000);

            //Set constant value to compare to
           const String stakeVal = "€ 150.00";
           Console.WriteLine(totalStake.Text);
            if (totalStake.Text.Equals(stakeVal))
            {
                Console.WriteLine("TOTAL STAKE WAS CALCULATED CORRECTLY");
            }
            else{
                Console.WriteLine("TOTAL STAKE WAS NOT CALCULATED CORRECTLY");
            }
            Thread.Sleep(2000);

            //Set constant value to compare to
           const String totToWinVal = "€ 550.00";
                Console.WriteLine(totalToWin.Text);
            if (totalToWin.Text.Equals(totToWinVal))
            {
                Console.WriteLine("TOTALTOWIN WAS CALCULATED CORRECTLY");
            }
            else{
                Console.WriteLine("TOTALTOWIN WAS NOT CALCULATED CORRECTLY");
            }
            submitBetSlip.Click();                         
            Thread.Sleep(1000);

        }
        public void placeBetsDifferentGames()
        {
            spinAndWinIcon.Click();
            Thread.Sleep(5000);
            oddEvenMarket.Click();
            Thread.Sleep(3000);
            highLowMarket.Click();
            Thread.Sleep(1000);
            neighboursMarket.Click();
            Thread.Sleep(1000);
            kenoMenuIcon.Click();
            Thread.Sleep(1000);
            evensOdd.Click();
            Thread.Sleep(2000);
            for (int i=1; i<=50; i++) {
            manualStakeEdit.Click();
            }
            Thread.Sleep(2000);

            //Set constant value to compare to
           const String stakeValB = "€ 200.00";
           Console.WriteLine(totalStake.Text);
            if (totalStake.Text.Equals(stakeValB))
            {
                Console.WriteLine("TOTAL STAKE WAS CALCULATED CORRECTLY");
            }
            else{
                Console.WriteLine("TOTAL STAKE WAS NOT CALCULATED CORRECTLY");
            }
            Thread.Sleep(2000);

            //Set constant value to compare to
           const String totToWinValB = "€ 750.00";
                Console.WriteLine(totalToWin.Text);
            if (totalToWin.Text.Equals(totToWinValB))
            {
                Console.WriteLine("TOTALTOWIN WAS CALCULATED CORRECTLY");
            }
            else{
                Console.WriteLine("TOTALTOWIN WAS NOT CALCULATED CORRECTLY");
            }
            submitBetSlip.Click();                         
            Thread.Sleep(1000);

        }

    }
    
}