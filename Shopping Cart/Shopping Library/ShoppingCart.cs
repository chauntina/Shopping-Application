using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Library
{
    public class ShoppingCart
    {
        List<ShoppingCartItem> _shoppingCarditems = new List<ShoppingCartItem>();
        protected string ShoppingCardItems;
        // private string ShoppingCard;
        private double _vat = 1.15;

       

        public ShoppingCart()
        {
        }

        public void AddShoppingItem(ShoppingCartItem item)
        {
            _shoppingCarditems.Add(item);
        }

      


        public double GetSubTotal()
        {
            double subTotal = 0;

            foreach (ShoppingCartItem item in _shoppingCarditems)
            {
                subTotal = subTotal + item.Price;
            }
            return subTotal;
        }

        public double GetSubTotalwithVAT()
        {
            double subTotal = GetSubTotal();

            return Math.Round(subTotal*_vat,2);
        }

        public List<ShoppingCartItem> ShoppingCartItems()
        {

            return _shoppingCarditems;
        }
    }
}
