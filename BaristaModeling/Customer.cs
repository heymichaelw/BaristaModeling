using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaModeling
{

    enum CustomerStatus
    {
        Welcomed, Banned
    }

    class Customer
    {
        public static string name;
        public int wallet;
        public float intake;
        //public int baristalike;
        public CustomerStatus customerstatus = CustomerStatus.Welcomed;
        

        public Customer(string _name)
        {
            name = _name;
            wallet = 20;
            intake = 0.0f;
            //baristalike = 3;

        }

        
        public int BuyDrink(Drink myDrink)
        {
            myDrink.CheckMenu();
            wallet -= myDrink.GetPrice();
            //baristalike--;
            myDrink.ordercount++;
            return wallet;
        }

        public int TipBarista()
        {
            wallet -= 1;
            //baristalike += 2;
            return wallet;
        }

        


    }
}
