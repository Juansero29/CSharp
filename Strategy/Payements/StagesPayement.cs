using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class StagesPayement : IPaymentStrategy
    {
        public float CalculateTotal(MyBasket myBasket)
        {
            float prix = 0;
            foreach (Article item in myBasket.articles)
            {
                prix += item.Price;
            }
            return myBasket.articles.Length >= 5 ? prix * 0.70f : myBasket.articles.Length >= 4 ? prix * 0.75f : myBasket.articles.Length >= 3 ? prix * 0.80f : myBasket.articles.Length >= 2 ? prix * 0.90f : prix;
        }
    }
}
