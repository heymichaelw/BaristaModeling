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
        public int friendliness;
        public CustomerStatus customerstatus = CustomerStatus.Welcomed;
        

        public Customer(string _name, char _gender, int _friendliness)
        {
            name = _name;
            wallet = 20;
            gender = _gender;
            intake = 0.0f;
            friendliness = _friendliness;

        }

        
        public int BuyDrink(Drink myDrink)
        {
            wallet -= myDrink.GetPrice();
            return wallet;
        }
    }
}
