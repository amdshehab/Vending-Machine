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

    }
}  