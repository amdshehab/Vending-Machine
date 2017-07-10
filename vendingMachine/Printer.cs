using System;
using vendingMachine;

namespace vendingMachine
{
    class Printer
    {
        public static string howToSelect = Environment.NewLine + "Please select an item by typing the item's Selection Number:" + Environment.NewLine;
        public static string header = "item name | item price | Selection Number" + Environment.NewLine;
        public static string purchasedItems = "item name | quantity" + Environment.NewLine;
        public static int length = Vendor.machine.Length;

        public static void printHeader()
        {
            for (int i = 0; i < length; i++)
            {
                header += $"{Vendor.machine[i].name} | £{Vendor.machine[i].price} | {i+1}" + Environment.NewLine;
            }
            Console.WriteLine(howToSelect + header);
            header = "";
        }
        public static void vendRequestedItems()
        {
            for(int i = 0; i < length; i++)
            {
                if (Vendor.machine[i].quantityToVend > 0)
                {
                    purchasedItems += $"{Vendor.machine[i].name} | {Vendor.machine[i].quantityToVend}" + Environment.NewLine;
                }
            }
            Console.WriteLine(purchasedItems);
        }
    }
}