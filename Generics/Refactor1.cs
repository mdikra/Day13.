using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Refactor1
    {
        public void FindMaximum<T>(T a, T b, T c)
        {
            if ((Comparer<T>.Default.Compare(a, b) > 0) && (Comparer<T>.Default.Compare(a, c) > 0) ||
                (Comparer<T>.Default.Compare(a, b) >= 0) && (Comparer<T>.Default.Compare(a, c) > 0) ||
                (Comparer<T>.Default.Compare(a, b) > 0) && (Comparer<T>.Default.Compare(a, c) >= 0))
            {
                Console.WriteLine(a + " is maximum");


            }
            else if ((Comparer<T>.Default.Compare(b, a) > 0 && (Comparer<T>.Default.Compare(b, c) > 0) ||
                (Comparer<T>.Default.Compare(b, a) >= 0) && (Comparer<T>.Default.Compare(b, c) > 0) ||
                (Comparer<T>.Default.Compare(b, a) > 0) && (Comparer<T>.Default.Compare(b, c) >= 0))
            {
                Console.WriteLine(b + " is maximum");


            }
            else if (Comparer<T>.Default.Compare(c, a) > 0 && (Comparer<T>.Default.Compare(c, b) > 0) ||
                (Comparer<T>.Default.Compare(c, a) >= 0) && (Comparer<T>.Default.Compare(c, b) > 0) ||
                (Comparer<T>.Default.Compare(c, a) > 0) && (Comparer<T>.Default.Compare(c, b) >= 0))
            {
                Console.WriteLine(c + " is maximum");


            }
            else
                Console.WriteLine("some input has value please check input again");
            
        }
    }
}