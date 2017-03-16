using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class NormalPayement : IPaymentStrategy
    {
        public float CalculateTotal(MyBasket myBasket)
        {
            /*float prix = 0;
            foreach (Article item in myBasket.articles)
            {
                prix += item.Price;
            }
            return prix;*/
            return myBasket.articles.Sum(a => a.Price);
        }
    }
}
