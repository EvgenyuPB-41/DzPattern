using System;
using System.Collections.Generic;
using System.Text;

namespace DzPattern
{
   public class ProtectiveGlass : IPrice
    {
        public IPrice IPhone { get; set; }

        public ProtectiveGlass(IPrice phone)
        {
            IPhone = phone;
        }

        public int PriceIPhone()
        {
            Console.WriteLine("Добавлено защитное стекло");
            return IPhone.PriceIPhone() + 1000;
        }
    }
}
