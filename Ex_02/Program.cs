using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm a change.");
        }
    }

    internal interface IMyBasket
    {
        void AddArticle(Article article);
        void AddArticles(params Article[] articles);
        void RemoveArticle(int index);
        Article this[int index] { get; set; }
        int ArticlesNumber();
    }

    struct Article
    {
        public string mName { get; set; }
        public float mPrice { get; set; }
    }

    class MyBasketArray : IMyBasket
    {
        private Article[] mArticles;
        public int Size { get { return mSize; } }
        private int mSize = 0;

        public void AddArticle(Article a)
        {
            mSize++;
            Article[] articles = new Article[mSize];
            mArticles.CopyTo(articles, 0);
            articles[mSize - 1] = a;
            mArticles = articles;
        }

        public void AddArticles(params Article[] articlesParams)
        {
            foreach (Article a in articlesParams)
            {
                AddArticle(a);
            }

        }

        public void RemoveArticle(int index)
        {
            Article[] dest = new Article[mArticles.Length - 1];
            if (index > 0)
                Array.Copy(mArticles, 0, dest, 0, index);

            if (index < mArticles.Length - 1)
                Array.Copy(mArticles, index + 1, dest, index, mArticles.Length - index - 1);
            mArticles = dest;
        }

        public Article this[int index]
        {
            get { return mArticles[index]; }
            set { mArticles[index] = value; }
        }
        public int ArticlesNumber()
        {
            return mArticles.Length;
        }
    }


    class MyBasketList : IMyBasket
    {
        private List<Article> mArticles;
        public int Size { get { return mArticles.Count; } }
        public void AddArticle(Article a)
        {
            mArticles.Add(a);
        }
        public void AddArticles(params Article[] articles)
        {
            mArticles.AddRange(articles);
        }
        public void RemoveArticle(int index)
        {
            mArticles.RemoveAt(index);
        }
        public Article this[int index]
        {
            get
            {
                return mArticles.ElementAt(index);
            }
            set
            {

            }
        }

        public int ArticlesNumber()
        {
            return mArticles.Count();
        }
    }
}
