using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum Number Problem");
            Console.WriteLine("maximum number:");
            int MaxNumber = TestCase.MaximumInteger(66, 22, 33);
            Console.WriteLine(MaxNumber);
            Double MaxDouble = TestCase.MaximumDouble(11, 23, 43);
            Console.WriteLine(MaxDouble);
            string MaxString = TestCase.MaximumString("21","55","11");
            Console.WriteLine(MaxString);
        }
    }
}
