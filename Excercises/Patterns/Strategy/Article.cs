using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Article
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public Article(string name, float price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            string a = $"[{Name} costs ${Price}]";
            return a;
        }
    }
}
