using System;
using Xunit;
using CalculatorLib;

namespace CalculatorLibUnitTests
{
    /*
     * A test program to use the functions in the calculator class
     * written by David Paul
     * 22 Feb 2021
     * ammended 22 Mar 2021
     */
    public class UnitTest1
    {
        [Fact]
        public void TestAdding2And4()
        {
            //Arrange
            double a = 2;
            double b = 4;
            double expected = 6;
            var calc = new Calculator();

            //Act
            double actual = calc.Add(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestSubtracting2From4()
        {
            //Arrange
            double a = 4;
            double b = 2;
            double expected = 2;
            var calc = new Calculator();

            //Act
            double actual = calc.Subtract(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMultiplying2And4()
        {
            //Arrange
            double a = 4;
            double b = 2;
            double expected = 8;
            var calc = new Calculator();

            //Act
            double actual = calc.Mutliply(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestDividing2into6()
        {
            //Arrange
            double a = 6;
            double b = 2;
            double expected = 3;
            var calc = new Calculator();

            //Act
            double actual = calc.Divide(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMedianEvenElements()
        {
            //Arrange
            double[] a = { 4, 1, 2, 3 };
            double expected = 2.5;
            var calc = new Calculator();

            //Act
            double actual = calc.Median(a);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]

        public void TestMedianOddElements()
        {
            //Arrange
            double[] a = { 4, 1, 2 };
            double expected = 2;
            var calc = new Calculator();

            //Act
            double actual = calc.Median(a);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        
        public void TestMean()
        {
            //Arrange
            double[] a = {1, 2, 3, 5, 8, 17 };
            double expected = 6;
            var calc = new Calculator();

            //Act
            double actual = calc.Mean(a);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
