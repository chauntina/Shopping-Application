using System;
using System.Collections.Generic;
using Shopping_Library;


namespace Shopping_Cart
{
    internal class Program
    {

            
            static void Main(string[] args)
            {
              ShoppingCart cart = new ShoppingCart();

                var item = new ShoppingCartItem("Xbox", 3200);

                cart.AddShoppingItem(item);

                 item = new ShoppingCartItem("Pasta", 15);
                cart.AddShoppingItem(item);

                item = new ShoppingCartItem("Sugar", 30);
                cart.AddShoppingItem(item);

                item = new ShoppingCartItem("Rice", 20);
                cart.AddShoppingItem(item);

                List<ShoppingCartItem> shoppingCarditems = cart.ShoppingCartItems();

           
                foreach (ShoppingCartItem shoppingCartItem  in shoppingCarditems)
                {
                    Console.WriteLine(shoppingCartItem.Name + "\t\t\t" + shoppingCartItem.Price);
                }

                Console.WriteLine("subtotal" + "\t" + cart.GetSubTotal());
                Console.WriteLine("With Vat" + "\t" + cart.GetSubTotalwithVAT());

            }

    }


    

}
