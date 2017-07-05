using vendingMachine;
using Xunit;
using System;

namespace Tests
{
    public class PricingTests
    {
        PricingSystem virtualSystem = new PricingSystem();
        [Fact]
        public void InsertingCoinsIncreasesBalance()
        {
            Assert.Equal(virtualSystem.balance, 0);
            virtualSystem.insertCoins(50);
            Assert.Equal(virtualSystem.balance, 50);
        }

        [Fact]
        public void CheckPurchaseReturnsChange()
        {
            Assert.Equal(virtualSystem.change, 0);
            virtualSystem.insertCoins(50);
            virtualSystem.checkPurchace(virtualSystem.balance, 40);
            Assert.Equal(virtualSystem.change, 10);
        }

    }
}  