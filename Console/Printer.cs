using System;
using vendingMachine;

namespace vendingMachine
{
    class Printer
    {
        public string header = "item name | item price" + Environment.NewLine;
        public void printHeader()
        {
            int length = Vendor.machine.Length;
            for (int i = 0; i < length; i++)
            {
                header += $"{Vendor.machine[i].name} | {Vendor.machine[i].price}";
            }
            Console.WriteLine(header);
        }
    }
}