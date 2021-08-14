using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum Number Problem");
            Console.WriteLine("Maximum number:");
            int[] intArray = { 122, 333, 444, 555, 666 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 11.1, 22.2, 33.3, 44.4, 55.5, 66.6 };
            GenericMaximum<double> generic1 = new GenericMaximum<double>(doubleArray);
            generic1.PrintMaxValue();

            string[] StringArray = { "12", "22", "33", "44", "66", "77" };
            GenericMaximum<string> generic2 = new GenericMaximum<string>(StringArray);
            generic2.PrintMaxValue();
        }
    }
}
