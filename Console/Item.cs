using System;

namespace vendingMachine
{
   public class Item
    {
        public string name;
        public double price;

        public Item(string itemName, double itemPrice)
        {
            name = itemName;
            price = itemPrice;
        }
    }
}
