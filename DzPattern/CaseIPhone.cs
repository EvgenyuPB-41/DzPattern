using System;
using System.Collections.Generic;
using System.Text;

namespace DzPattern
{
   public class CaseIPhone : IPrice
    {
        public IPrice IPhone { get; set; }

        public CaseIPhone(IPrice phone)
        {
            IPhone = phone;
        }

        public int PriceIPhone()
        {
            Console.WriteLine("Добавлен чехол");
            return IPhone.PriceIPhone() + 5000;
        }

    }
}
