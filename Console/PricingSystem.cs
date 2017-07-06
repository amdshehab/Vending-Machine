using vendingMachine;
using System;
namespace vendingMachine
{
    public class PricingSystem
    {

        public double balance = 0;
        public double change = 0;

        public bool transactionComplete = false;
        public void insertCoins(double amount, double priceOfItem)
        {
            balance+=amount;
            checkPurchace(balance, priceOfItem);
        }

        public void checkPurchace(double currentBalance, double priceOfItem)
        {
            if (currentBalance >= priceOfItem)
            {
                change = currentBalance - priceOfItem;
                Console.WriteLine($"this is your change {change}");
                transactionComplete = true;
            }
        }
    }
}