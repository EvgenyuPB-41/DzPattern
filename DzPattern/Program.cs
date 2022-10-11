using System;

namespace DzPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPhone iphone = new IPhone("222");
            Seller seller = new Seller();
            seller.sell = iphone;
            seller.Sell1();

            IPrice phone = new IPhone("Iphone12 Pro Max");
            phone = new CaseIPhone(phone);
            phone = new ProtectiveGlass(phone);
            Console.WriteLine("Итоговая стоимость" + phone.PriceIPhone());
        }
    }
}
