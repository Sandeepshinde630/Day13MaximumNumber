using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumber
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T[] value;
        public GenericMaximum(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T Maxvalue(T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = Maxvalue(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = Maxvalue(this.value);
            Console.WriteLine("Max value is :" + max);
        }
    }
}

