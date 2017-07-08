using System;
using vendingMachine;

namespace vendingMachine
{
    class Printer
    {
        public string howToSelect = Environment.NewLine + "Please select an item by typing the item's Selection Number:" + Environment.NewLine;
        public string header = "item name | item price | Selection Number" + Environment.NewLine;
        public void printHeader()
        {
            int length = Vendor.machine.Length;
            for (int i = 0; i < length; i++)
            {
                header += $"{Vendor.machine[i].name} | £{Vendor.machine[i].price} | {i+1}" + Environment.NewLine;
            }
            Console.WriteLine(howToSelect + header);
            header = "";
        }
    }
}