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
        public char color;
        public bool onMenu;

        public Drink(string _name, string _type, float _caffeine, int _price, char _color)
        {
            name = _name;
            type = _type;
            caffeine = _caffeine;
            price = _price;
            color = _color;
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


    }
}
