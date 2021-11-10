using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class ExtendMax
    {
        public class GenericsMaximum<T> where T : IComparable
        {
            public T[] value;
            public GenericsMaximum(T[] value)
            {
                this.value = value;
            }
            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }
            public T MaxValue(params T[] values)
            {
                var Sorted_values = Sort(values);
                return Sorted_values[^1];

            }
            public T MaxMethod()
            {
                var max = MaxValue(this.value);
                return max;
            }
            public void PrintMaxValue()
            {
                var max = MaxValue(this.value);
                Console.WriteLine("Maximum value is " + max);

            }
        static void Main(string[] args)
            {
                int[] arr = { 112, 344, 432, 555, 678 };
                GenericsMaximum<int> generic = new GenericsMaximum<int>(arr);
                generic.PrintMaxValue();

            }
        }
    }
}
