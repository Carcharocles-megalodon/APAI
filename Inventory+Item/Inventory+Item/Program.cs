using System;
using System.Collections.Generic;
using System.Xml;

namespace Inventory_Item
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("inventory.xml");
            Inventory inventory = new Inventory();

            foreach(XmlNode item in xml.DocumentElement)
            {
                List<string> properties = new List<string>();
                foreach(XmlNode property in item.ChildNodes)
                {
                    properties.Add(property.InnerText);
                }
                inventory.AddItem(new InventoryItem(properties[0], properties[1], properties[2]));
            }
            Console.WriteLine(inventory.ToString());

        }
    }
}
