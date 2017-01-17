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
        public char gender;
        public float intake;
        public int baristalike;
        public CustomerStatus customerstatus = CustomerStatus.Welcomed;
        

        public Customer(string _name, char _gender)
        {
            name = _name;
            wallet = 20;
            gender = _gender;
            intake = 0.0f;
            baristalike = 3;

        }

        
        public int BuyDrink(Drink myDrink)
        {
            wallet -= myDrink.GetPrice();
            baristalike--;
            return wallet;
        }

        public int TipBarista()
        {
            wallet -= 1;
            baristalike += 2;
            return wallet;
        }

        public string SurpriseMe()
        {
            if (gender == 'M')
            {

            }



            return Drink.name;
        }


    }
}
