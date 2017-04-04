using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Question q1 = new Question("Are trees green?\n");
            q1.Add(new Solution("Yes they are", true));
            q1.Add(new Solution("No, they are obviously red", false));
            q1.Add(new Solution("Who gives a fuck, let's smoke!", false));
            WriteLine(q1);
            WriteLine("\nAnd...\n");
            foreach(Solution s in q1)
            {
                WriteLine(s);
            }
        }
                
        class RandomDraw<T> : IEnumerable<T>
            where T : struct
        {

            protected List<T> myList = new List<T>();
            static Random rnd = new Random();
            public RandomDraw()
            {

            }
            public void Add(T myElement)
            {
                myList.Add(myElement);
            }

            public void AddRange(params T[] myTArray)
            {
                myList.AddRange(myTArray);
            }

            public T Pop()
            {
                int index;
                if (myList.Count == 0)
                {
                    return default(T);
                }
                index = rnd.Next(0, myList.Count);
                T buff = myList[index];
                myList.RemoveAt(index);
                return buff;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                foreach (T somthing in myList)
                {
                    sb.Append($"{somthing}\n");
                }
                return sb.ToString();
            }

            public IEnumerator<T> GetEnumerator()
            {
                foreach (T a in myList)
                {
                    yield return a;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        struct Solution
        {
            public Solution(string answer, bool right)
            {
                mText = answer;
                mCorrect = right;
            }
            public string mText;
            public bool mCorrect;

            public override string ToString()
            {
                return $"{mText} - {mCorrect}";
            }

        }

        class Question : RandomDraw<Solution>
        {
            public string mQuestion;

            public Question(string text)
            {
                mQuestion = text;
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(mQuestion + "\n");
                foreach (Solution s in myList)  
                {
                    sb.Append(s.mText + "\n");
                }
                return sb.ToString();
            }

        }
    }
}
