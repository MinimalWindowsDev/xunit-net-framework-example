using System;
using Xunit;

namespace xUnit_NET_Framework_MWE.Tests
{
    public class CalculatorTests
    {
        private readonly SimpleCalculator _calculator;

        public CalculatorTests()
        {
            _calculator = new SimpleCalculator();
        }

        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            int a = 5, b = 10;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(15, result);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, -10, 5)]
        public void Subtract_TwoNumbers_ReturnsDifference(int a, int b, int expected)
        {
            int result = _calculator.Subtract(a, b);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            int result = _calculator.Multiply(4, 5);
            Assert.Equal(20, result);
        }

        [Fact]
        public void Divide_NonZeroDenominator_ReturnsQuotient()
        {
            double result = _calculator.Divide(10, 2);
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(5, 0));
        }
    }
}