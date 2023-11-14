using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item("Axe", "12345", 23,12);
            Item item3 = new Item("Shotgun", "12334567", 3, 4);
            Item item2 = new Item("Shovel", "945687893112", 1,8);
            Item item4 = new Item("Rifle", "8567123", 15,100);
            // Item item5 = new Item("Rifle", "8567123", 15,100);
            Inventory inventory = new Inventory();

          
            inventory.AddItem(item1);
            inventory.AddItem(item2);
            inventory.AddItem(item3);
            inventory.AddItem(item4);
           
            Console.WriteLine(inventory);

            Console.WriteLine("-------------------");
            inventory.DeleteItem(item1);
            Console.WriteLine(inventory);

            Console.ReadLine();
        }
    }
}
