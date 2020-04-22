using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_Item
{
    class Inventory
    {
        List<InventoryItem> inventory = new List<InventoryItem>();
        public void AddItem(InventoryItem item)
        {
            inventory.Add(item);
        }
        public override string ToString()
        {
            string stock ="";   
            for(int i = 0; i < inventory.Count; i++)
            {
                stock += string.Format("Item nº: {0}\n", inventory[i]);
            }
            return stock;
        }
    }
}
