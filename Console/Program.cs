using System;

namespace vendingMachine
{
    class Program
    {

        public static void Main(string[] args)
        {
            var vendingMachineRunner = new Controller();
            vendingMachineRunner.selectYourItem();
            vendingMachineRunner.payment();
        }
    }
}
