using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaModeling
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink java = new Drink("Java", "coffee", 0.6f, 3);
            Drink redeye = new Drink("Red Eye", "coffee", 0.9f, 5);
            Drink latte = new Drink("Latte", "milk", 0.4f, 4);
            Drink hotchoc = new Drink("Hot Chocolate", "milk", 0f, 4);

            Customer tommy = new Customer("Tommy", 3.0f);
            Customer ashley = new Customer("Ashley", 1.5f);
            Customer fred = new Customer("Fred", 0.4f);

            ashley.BuyDrink(redeye);
            Console.WriteLine(ashley);
            ashley.BuyDrink(redeye);


        }

        
    }
}
