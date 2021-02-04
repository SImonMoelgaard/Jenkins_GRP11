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
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        { 
            Accumulator = a * b;
            return Accumulator;
        }

        public double Power(double a, double b)
        {
            Accumulator = Math.Pow(a, b);
            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {
            Accumulator = dividend / divisor;
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double AcumulatorAdd(double addend)
        {
            return Accumulator + addend;
        }

        public double AcumulatorSub (double Subend)
        {
            return Accumulator - Subend;
        }

        public double AcumulatorMulti (double Multiend)
        {
            return AcumulatorMulti * Multiend; 
        }
    }
}
