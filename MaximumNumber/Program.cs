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
        }
    }
}
