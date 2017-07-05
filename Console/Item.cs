using System;

namespace vendingMachine
{
   public class Item
    {
        public string name;
        public int price;

        public Item(string itemName, int itemPrice)
        {
            name = itemName;
            price = itemPrice;
        }
    }
}
