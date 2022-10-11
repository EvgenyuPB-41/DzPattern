using System;
using System.Collections.Generic;
using System.Text;

namespace DzPattern
{
   public  class IPhone : IPrice, ISell
    {

        public string Model { get; protected set; }

        public IPhone(string model)
        {
            Model = model;
        }

        public void Sell()
        {
            Console.WriteLine("Айфон продан");
        }

        public int PriceIPhone()
        {
            
            return 150000; 
        }
    }
}
