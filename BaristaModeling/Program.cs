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
            Drink java = new Drink("Java", "coffee", 0.6f, 3, 'b');
            Drink redeye = new Drink("Red Eye", "coffee", 0.9f, 5, 'b');
            Drink applejuice = new Drink("Apple Juice", "juice", 0f, 4, 'y');
            Drink orangejuice = new Drink("Orange Juice", "juice", 0f, 4, 'o');

            Customer tommy = new Customer("Tommy", 'M');
            Customer ashley = new Customer("Ashley", 'F');

            
            

        }

        
    }
}
