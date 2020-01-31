using System;

namespace basiccalculator
{
    public class Calculator
    {
        static public int Add(int a, int b)
        {
            var c = a + b;

            return c;
        }
        static public int Subtract(int a, int b)
        {
            var c = a - b;

            return c;
        }
        static public int Multiply(int a, int b)
        {
            var c = a * b;
        }
        static public int Divide(int a, int b)
        {
            var c = a / b;
        }

    }
}
