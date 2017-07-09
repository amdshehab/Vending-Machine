using vendingMachine;
using Xunit;
using System;

namespace Tests
{
    public class PricingTests
    {
        private const decimal priceOfPepsi = 1.0m;
        PricingSystem virtualSystem = new PricingSystem();
        [Fact]
        public void InsertingCoinsIncreasesBalance()
        {
            Assert.Equal(virtualSystem.balance, 0);
            virtualSystem.insertCoins(0.50m, priceOfPepsi);
            Assert.Equal(virtualSystem.balance, 0.50m);
        }

        [Fact]
        public void CheckPurchaseReturnsChange()
        {
            Assert.Equal(virtualSystem.change, 0.0m);
            virtualSystem.insertCoins(0.50m, priceOfPepsi);
            virtualSystem.checkPurchace(virtualSystem.balance, 0.40m);
            Assert.Equal(virtualSystem.change, 0.10m);
        }
    }
}  