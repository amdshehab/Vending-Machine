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
        Item product = new Item("pepsi", 5);
        Assert.Equal(product.price,5);
        Assert.Equal(product.name, "pepsi");
        }
    }
}
