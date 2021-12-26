using System;
using System.Collections.Generic;

/*
UC4- Extend the max method to take more then three parameters
- Use Options and use Sorting
UC5- Extend the max method to also print the max to std out using Generic Method
- Write printMax Generic Method which is internally called from testMaximum
 */

namespace FindMaximumNumberProject
{
    public class GenericMax<T> where T : IComparable
    {
        public T[] value;
        public GenericMax(T[] value)
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
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
    }
}
