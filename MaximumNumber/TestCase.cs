using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumber
{
    class TestCase
    {
        public static int MaximumInteger(int Num1, int Num2, int Num3)
        {

            if (Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) > 0)
            {
                return Num1;

            }
            else if (Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) > 0)
            {
                return Num2;
            }
            else if (Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) > 0)
            {
                return Num3;
            }
            throw new Exception("Num1,Num2,Num3 are same");
        }
        public static Double MaximumDouble(Double Num1, Double Num2, Double Num3)
        {

            if (Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) > 0)
            {
                return Num1;

            }
            else if (Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) > 0)
            {
                return Num2;
            }
            else if (Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) > 0)
            {
                return Num3;
            }
            throw new Exception("Num1,Num2,Num3 are same");
        }
        public static string MaximumString(string Num1, string Num2, string Num3)
        {

            if (Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) > 0)
            {
                return Num1;
            }
            else if (Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) > 0)
            {
                return Num2;
            }
            else if (Num3.CompareTo(Num2) > 0 && Num3.CompareTo(Num1) > 0)
            {
                return Num3;
            }
            throw new Exception("first,second,Third are same");

        }
    }
}
