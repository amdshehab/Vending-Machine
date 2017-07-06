using vendingMachine;
using System;
namespace vendingMachine
{
    public class PricingSystem
    {

        public decimal balance = 0;
        public decimal change = 0;

        public bool transactionComplete = false;
        public void insertCoins(decimal amount, decimal priceOfItem)
        {
            balance+=amount;
            checkPurchace(balance, priceOfItem);
        }

        public void checkPurchace(decimal currentBalance, decimal priceOfItem)
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