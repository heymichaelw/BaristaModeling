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
        public float tolerance;
        //public int baristalike;
        //public CustomerStatus customerstatus = CustomerStatus.Welcomed;
        

        public Customer(string _name, float _tolerance)
        {
            name = _name;
            tolerance = _tolerance;
            wallet = 20;
            intake = 0.0f;
            //baristalike = 3;

        }


        public int BuyDrink(Drink myDrink)
        {
            if (intake < tolerance - myDrink.caffeine)
            {
                if (wallet > 0)
                {
                    if (myDrink.onMenu == true)
                    {
                        myDrink.ordercount++;
                        wallet -= myDrink.GetPrice();
                        //baristalike--;
                        myDrink.onMenu = myDrink.CheckMenu();
                        intake += myDrink.caffeine;
                    }

                    else
                    {
                        Console.WriteLine("Sorry, that is sold out!");
                    }

                }
                else
                {
                    Console.WriteLine("Sorry, it looks like your wallet is empty.");
                }
            }
            else
            {
                Console.WriteLine("Maybe try something with less caffeine!");
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
            return $"{name} : {wallet} : {intake}";
        }


    }
}
