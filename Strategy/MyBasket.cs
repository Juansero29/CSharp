using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MyBasket
    {
        public float TotalPrice { get { return strategy.CalculateTotal(this); } }
        public Article[] articles;
        public IPaymentStrategy strategy;

        public void FillBasket(params Article[] articles)
        {
            this.articles = articles;
        }
        public void ChoosePaymentStrategy(IPaymentStrategy strategy)
        {
            this.strategy = strategy;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("This basket contains: ");
            foreach (Article a in articles)
            {
                s.Append($"{a} ");
            }
            s.Append(".\n");
            return s.ToString();
        }
    }
}
