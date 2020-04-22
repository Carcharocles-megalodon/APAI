using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_Item
{
    class InventoryItem
    {

        public string name_ { get; set; }

        public int weight_ { get; set; }

        public int qty_ { get; set; }
        public InventoryItem(string name, string weight, string qty)
        {
            this.name_ = name;
            this.qty_ = int.Parse(qty);
            this.weight_ = int.Parse(weight);
        }
        public override string ToString()
        {
            return string.Format("\n\tName: {0}\n\tWeight: {1}\n\tQuantity: {2}", this.name_, this.weight_, this.qty_);
        }

    }
}
