using System;
using vendingMachine;

namespace vendingMachine
{
    public class Controller
    {
        PricingSystem moneyMachine = new PricingSystem();
        Printer printer = new Printer();

        static Item selectedItem;
        decimal acceptedCoins = 0.50m;
        int userChoice = 0;
        public void selectYourItem()
        {
            printer.printHeader();
            if (handleUserInput())
            {
                checkSelectionInArray();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                selectYourItem();
            }
        }

        public void payment()
        {
            while (moneyMachine.transactionComplete == false)
            {
                Console.WriteLine("To insert coins, press 1. To cancel, 2");
                if (handleUserInput())
                {
                    selectionProcessing(userChoice);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        private void selectionProcessing(int selection)
        {
            switch(selection)
            {
                case 1:
                    Console.WriteLine($"current payment ---> £{acceptedCoins}");
                    moneyMachine.insertCoins(acceptedCoins, selectedItem.price);
                    break;
                case 2:
                    Console.WriteLine("see you later");
                    moneyMachine.transactionComplete = true;
                    break;
                default:
                    Console.WriteLine("You have made an invalid selection");
                    break;
            }
        }

        private void checkSelectionInArray()
        {
            if (userChoice-1 < Vendor.machine.Length && userChoice-1 >= 0)
            {
                selectedItem = Vendor.machine[userChoice-1];
                Console.WriteLine($"you have chosen {selectedItem.name}");
            }
            else
            {
                Console.WriteLine("the item number selected does not exist, please try again");
                selectYourItem();
            }
        }

        private Boolean handleUserInput()
        {
           return Int32.TryParse(Console.ReadLine(), out userChoice);
        }
    }
}