using System;

namespace Calculator
{
    public class Calculator
    {


        public double Accumulator
        { get; set; }
        

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
            if (Accumulator == 0 )
            {
                throw new InvalidOperationException();
            }
            else
            {
                Accumulator = 0;
            }
           

        }

        public double AccumulatorAdd(double addend)
        {
            Accumulator = Accumulator + addend;
            return Accumulator;
        }

        public double AccumulatorSub (double Subend)
        {
            Accumulator= Accumulator - Subend;
            return Accumulator;
        }

        public double AccumulatorMulti(double Multiend)
        {
            Accumulator= Accumulator * Multiend;
            return Accumulator;
        }

        public double AccumulatorPower(double b)
        {
            Accumulator = Math.Pow(Accumulator, b);
            return Accumulator;
        }

        public double AccumulatorDivide(double divisor)
        {
            Accumulator = Accumulator / divisor;
            return Accumulator;
        }
    }
}
