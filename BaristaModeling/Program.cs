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

            Customer tommy = new Customer("Tommy");
            Customer ashley = new Customer("Ashley");
            Customer fred = new Customer("Fred");

            ashley.BuyDrink(java);
            tommy.BuyDrink(java);
            tommy.BuyDrink(java);
            tommy.BuyDrink(java);
            tommy.BuyDrink(java);
            tommy.BuyDrink(java);
            tommy.BuyDrink(java);
            tommy.BuyDrink(java);
            ashley.BuyDrink(java);
            ashley.BuyDrink(java);
            ashley.BuyDrink(java);
            Console.WriteLine(ashley);
            Console.WriteLine(java);

        }

        
    }
}
