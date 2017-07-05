using Xunit;
using vendingMachine;

namespace Tests
{
    public class VendorTests
    {
        [Fact]
        public void VendingMachineContainsWaterAndCrisps()
        {
            Vendor oldMachine = new Vendor();
            Assert.Equal(oldMachine.machine.Length,2);
        }
    } 
}