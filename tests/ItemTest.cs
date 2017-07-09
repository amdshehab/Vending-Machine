using vendingMachine;
using System;
using Xunit;

namespace Tests
{
    public class ItemTest
    {
        [Fact]
        public void TestWorkingConstructor()
        {
        Item product = new Item("pepsi", 0.50m);
        Assert.Equal(product.price, 0.50m);
        Assert.Equal(product.name, "pepsi");
        }
    }
}
