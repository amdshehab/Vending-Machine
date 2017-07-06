using System;
using vendingMachine;

namespace vendingMachine
{
    public class Controller
    {
        PricingSystem moneyMachine = new PricingSystem();
        static Item selectedItem;
        double acceptedCoins = 0.50;
        public void selectYourItem()
        {
            Console.WriteLine("Please select your item number");
            handleFirstUserInput();
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
                    moneyMachine.insertCoins(acceptedCoins, selectedItem.price);
                    break;
                case 2:
                    Console.WriteLine("see you later");
                    moneyMachine.transactionComplete = true;
                    break;
            }
        }

        public void handleFirstUserInput()
        {
             int index = 0;
             if (Int32.TryParse(Console.ReadLine(), out index))
             {
                 if (index-1 < Vendor.machine.Length && index-1 >= 0)
                 {
                    selectedItem = Vendor.machine[index-1];
                 }
                 else
                 {
                     Console.WriteLine("the item number selected does not exist, please try again");
                     selectYourItem();
                 }
             }
             else
             {
                 Console.WriteLine("Invalid Input");
                 selectYourItem();
             }
        }
    }
}