using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBasket chochi = new MyBasket();
            chochi.FillBasket(new Article("Pizza", 2.5f), new Article("Milk", 4.5f), new Article("Teddy Bear", 5.5f), new Article("Shampoo", 9.8f));

            Console.Write(chochi);

            chochi.ChoosePaymentStrategy(new NormalPayement());
            Console.WriteLine($"The total price with a normal payement is {chochi.TotalPrice}");

            chochi.ChoosePaymentStrategy(new GiftedVAT());
            Console.WriteLine($"The total price with a gifted VAT payement is {chochi.TotalPrice}$");
            chochi.ChoosePaymentStrategy(new StagesPayement());
            Console.WriteLine($"The total price with a stages payement is  {chochi.TotalPrice}");
            Console.ReadKey(true);
        }
    }
}
