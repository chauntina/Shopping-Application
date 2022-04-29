using System;
using System.Collections.Generic;

namespace Shopping_Library
{

    public class ShoppingCartItem
    {

        public double _price;
        public string _name;
        

        public ShoppingCartItem(string name, double price)
        {

            _price = price;
            _name = name;

            //foreach (string ShoppingCartItem in item)
            //{
            //    Console.WriteLine(ShoppingCartItem);
                
            //}
           
        }

        public string Name
        { 
            get { return _name; } 
        }

        public double Price
        {
            get { return _price; }

        }    
    }

}


