using NUnit.Framework;
using AutomationBetMan.BaseClass;
using AutomationBetMan.ObjectRepo.FootballObjects.Single;
using System.Threading;

namespace AutomationBetMan.TestCases
{
    [TestFixture]
    public class MultipleBetBonusTest : BaseTest
    {
        [Test]
        public void TestMultipleBetBonus()
        {
            var bonusMultiplebet = new FootballBonusing(driver);
            bonusMultiplebet.PlaceMultiplebet();
            Thread.Sleep(2000);
        }
    }
}
