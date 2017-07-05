using vendingMachine;
namespace vendingMachine
{
    public class PricingSystem
    {

        public int balance = 0;
        public int change = 0;

        public bool transactionComplete = false;
        // system has a balance that is 0 to begin with

        // system takes variable and compares it to balance
        // if variable = or is greater than the balance
        // system breaks loop

        // system has a method by which you can add money to it

        // main controller has a const by which we change what the user can insert
        public void insertCoins(int amount)
        {
            balance+=amount;
        }

        public void checkPurchace(int currentBalance, int priceOfItem)
        {
            if (currentBalance >= priceOfItem)
            {
                change = currentBalance - priceOfItem;
                transactionComplete = true;
            }
        }
    }
}