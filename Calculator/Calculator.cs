using System;

namespace Calculator
{
    public class Calculator
    {

        public double Accumulator { get; private set; }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Divide(double dividend, double divisor)
        {
            return dividend / divisor;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double add(double addend)
        {
            return Accumulator + addend;
        }

    }
}
