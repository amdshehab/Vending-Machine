using Xunit;
using vendingMachine;

namespace Tests
{
    public class VendorTests
    {
        [Fact]
        public void VendingMachineContainsWaterAndCrisps()
        {
            Assert.Equal(Vendor.machine.Length,2);
            Assert.Equal(Vendor.machine[0].name,"Bottled Water");
        }
    } 
}