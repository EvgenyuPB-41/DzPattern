using System;
using System.Collections.Generic;
using System.Text;

namespace DzPattern
{
   public class Seller
    {
        public ISell sell;

        public void Sell()
        {
            sell.Sell();
        }

        public void Sell1()
        {
            Console.WriteLine("Айфон продан");
        }
    }
}
