using System;
using vendingMachine;

namespace vendingMachine
{
    public class Controller
    {
        PricingSystem moneyMachine = new PricingSystem();
        public static void SelectYourItem()
        {
            Console.WriteLine("Please select your item number");
            int index = Int32.Parse(Console.ReadLine());
            var selectedItem = Vendor.machine[index];
            Console.WriteLine($"you have chosen {selectedItem.name}");
        }
    }
}