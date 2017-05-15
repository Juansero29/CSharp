using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complements
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((-13).Abs().Bounds(0, 9).ToLetter());
        }

    }

    public static class MyExtensionMethods
    {
        public static int Abs(this int i)
        {
            return Math.Abs(i);
        }

        public static int Bounds(this int i, int lowerBound, int highestBound)
        {
            return i <= lowerBound ? lowerBound : i >= highestBound ? highestBound : i;
        }

        public static string ToLetter(this int i)
        {
            switch (i)
            {
                case 0:
                    return "Zero";
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";
                case 10:
                    return "Ten";
                default:
                    return "I don't know";
            }
        }


    }
}
