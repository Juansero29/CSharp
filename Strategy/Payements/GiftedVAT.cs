using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class GiftedVAT : IPaymentStrategy
    {
        public float CalculateTotal(MyBasket myBasket)
        {
            float prix = 0;
            foreach (Article item in myBasket.articles)
            {
                prix += item.Price - (item.Price * 0.20f);
            }
            return prix;
        }
    }
}
