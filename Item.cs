using System;

namespace vendingMachine
{
    class Item
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
