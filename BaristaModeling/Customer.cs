using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaModeling
{

    //enum CustomerStatus
    //{
    //    Welcomed, Banned
    //}

    class Customer
    {
        public string name;
        public int wallet;
        public float intake;
        //public int baristalike;
        //public CustomerStatus customerstatus = CustomerStatus.Welcomed;
        

        public Customer(string _name)
        {
            name = _name;
            wallet = 20;
            intake = 0.0f;
            //baristalike = 3;

        }


        public int BuyDrink(Drink myDrink)
        {
            while (myDrink.onMenu == true)
            {
                //myDrink.ordercount++;
                //wallet -= myDrink.GetPrice();
                //baristalike--;
                //myDrink.onMenu = myDrink.CheckMenu();
            }
              
             else
            {
                Console.WriteLine("Sorry, that is sold out!");
            }
            return wallet;
        }

        public int TipBarista()
        {
            wallet -= 1;
            //baristalike += 2;
            return wallet;
        }

        public override string ToString()
        {
            return $"{name} : {wallet}";
        }


    }
}
