using System;
using vendingMachine;

namespace vendingMachine
{
    public class Controller
    {
        PricingSystem moneyMachine = new PricingSystem();
        Printer printer = new Printer();
        static Item selectedItem;
        private const decimal acceptedCoins = 0.50m;
        private int userChoice = 0;
        
        public void selectYourItem()
        {
            Printer.printHeader();
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
                Console.WriteLine(Environment.NewLine + 
                "To pay for your items: press 1, To choose another item: 2, or To cancel: 3");
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
                    startPaymentProcess();
                    break;
                 case 2:
                    selectYourItem();
                    break;
                case 3:
                    Console.WriteLine("see you later");
                    moneyMachine.transactionComplete = true;
                    break;
                default:
                    Console.WriteLine("You have made an invalid selection");
                    break;
            }
        }

        private void startPaymentProcess(){
            while(moneyMachine.transactionComplete == false)
            {
                Console.WriteLine("press 1 to insert £0.50 coins");
                switch(Console.ReadLine())
                {
                    case "1":
                    Console.WriteLine($"current payment ---> £{acceptedCoins}");
                    moneyMachine.insertCoins(acceptedCoins, moneyMachine.totalAmount);
                    break;

                    default:
                    Console.WriteLine("Invalid input");
                    break;
                }
            }
        }
        private void checkSelectionInArray()
        {
            if (userChoice-1 < Vendor.machine.Length && userChoice-1 >= 0)
            {
                selectedItem = Vendor.machine[userChoice-1];
                Console.WriteLine($"you have chosen {selectedItem.name}");
                quantityCheck();
            }
            else
            {
                Console.WriteLine("the item number selected does not exist, please try again");
                selectYourItem();
            }
        }
        private void quantityCheck()
        {
            Console.WriteLine($"please select the amount of {selectedItem.name} you want? ");
            if (handleUserInput())
            {
                moneyMachine.totalAmount += selectedItem.price*userChoice;
                selectedItem.quantityToVend += userChoice;
                Console.WriteLine(Environment.NewLine +
                $"You have added {userChoice} {selectedItem.name} ||| Total: £{moneyMachine.totalAmount}");
            }
            else
            {
                Console.WriteLine("invalid selection");
                quantityCheck();
            }
        }
        private Boolean handleUserInput()
        {
           return Int32.TryParse(Console.ReadLine(), out userChoice);
        }
    }
}