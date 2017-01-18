using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaModeling
{


    class Drink
    {
        public static string name;
        public string type;
        public float caffeine;
        private int price;
        public int ordercount;
        public bool onMenu;

        public Drink(string _name, string _type, float _caffeine, int _price)
        {
            name = _name;
            type = _type;
            caffeine = _caffeine;
            price = _price;
            ordercount = 0;
            onMenu = true;
        }

        public int GetPrice()
        {
             return price;
        }

        public void OnSale()
        {
            price--;
        }

        public void DeCaf()
        {
            caffeine = 0;
        }

        //checking to see if drink is sold out (only 10 in stock of each)
        public bool CheckMenu()
        {
            if (ordercount > 10)
            {
                onMenu = false;
            }
            return onMenu;
        }

        public override string ToString()
        {
            return $"{ordercount} : {onMenu}";
        }


    }
}
