using System;
using Calculator;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        [TestCase(3, 0, 3)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }


        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
		[TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }


        [TestCase(6, 2, 3)]
        [TestCase(10, 2, 5)]
        [TestCase(30, 6, 5)]
        [TestCase(100, 10, 10)]
        public void Divide_ResultIsCorrect(double divideend, double divisor, double result)
        {
            Assert.That(_uut.Divide(divideend, divisor), Is.EqualTo(result));
        }


        [TestCase(1, 5)]
        [TestCase(2,6)]
        [TestCase(5, 9)]
        [TestCase(10, 14)]
        public void AcumilatorAdd(int c,int result)
        {
            _uut.Accumulator = 4;
            Assert.That(_uut.AccumulatorAdd(c), Is.EqualTo(result));
        }

        [TestCase(1, 9)]
        [TestCase(2, 8)]
        [TestCase(5, 5)]
        [TestCase(9, 1)]
        public void AcumilatorSub(int c, int result)
        {
            _uut.Accumulator = 10;
            Assert.That(_uut.AccumulatorSub(c), Is.EqualTo(result));
        }


        [TestCase(2, 10)]
        [TestCase(3, 15)]
        [TestCase(5, 25)]
        [TestCase(9, 45)]
        public void AcumilatorMulti(int c, int result)
        {
            _uut.Accumulator = 5;
            Assert.That(_uut.AccumulatorMulti(c), Is.EqualTo(result));
        }



        [TestCase(2, 25)]
        [TestCase(3, 125)]
        [TestCase(4, 750)]
        public void AcumilatorPower(int c, int result)
        {
            _uut.Accumulator = 5;
            Assert.That(_uut.AccumulatorPower(c), Is.EqualTo(result));
        }

        [TestCase(2, 10)]
        [TestCase(4, 5)]
        [TestCase(10, 2)]
        public void AcumilatorDivide(int c, int result)
        {
            _uut.Accumulator = 20;
            Assert.That(_uut.AccumulatorDivide(c), Is.EqualTo(result));
        }


        [TestCase()]
        public void ClearAcumilator()
        {
            Assert.Throws<InvalidOperationException>(() =>_uut.Clear());
        }

    }
}
