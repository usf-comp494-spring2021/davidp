using System;

namespace CalculatorLib
{
    /*
     * Calculator class with add multiply divide and subtract
     * written by David Paul
     * 22 Feb 2021
     */
    public class Calculator
    {
        /*
         *param double a a number to be added
         *param double b a number to be added
         *return the numbers added together
        */
        public double Add(double a, double b)
        {
            return (a + b);
        }
        /*
         *param double a a number to be subtracted from
         *param double b the number to be subtracted
         *return b subtracted from a
        */
        public double Subtract(double a, double b)
        {
            return (a - b);
        }
        /*
         *param double a a number to be multiplied
         *param double b a number to be multiplied
         *return the numbers multiplied together
        */
        public double Mutliply(double a, double b)
        {
            return (a * b);
        }
        /*
         *param double a a number to be divided from
         *param double b a number to be divided into
         *return the number of times b goes into a
        */
        public double Divide(double a, double b)
        {
            return (a / b);
        }
    }
}
