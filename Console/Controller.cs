using System;
using vendingMachine;

namespace vendingMachine
{
    public class Controller
    {
        PricingSystem moneyMachine = new PricingSystem();
        static Item selectedItem;
        int acceptedCoins = 50;
        public void selectYourItem()
        {
            Console.WriteLine("Please select your item number");
            int index = Int32.Parse(Console.ReadLine());
            selectedItem = Vendor.machine[index-1];
            Console.WriteLine($"you have chosen {selectedItem.name}");
        }

        public void payment()
        {
            while (moneyMachine.transactionComplete == false)
            {
                Console.WriteLine("To insert coins, press 1. To cancel, 2");
                int choice = Int32.Parse(Console.ReadLine());
                selectionProcessing(choice);
            }
        }

        public void selectionProcessing(int selection)
        {
            switch(selection)
            {
                case 1:
                    Console.WriteLine("you have paid 50 cents");
                    moneyMachine.insertCoins(acceptedCoins);
                    break;
                case 2:
                    Console.WriteLine("see you later");
                    break;
            }
        }
    }
}