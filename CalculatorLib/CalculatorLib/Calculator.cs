using System;
using System.Collections;

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
        /*
        *param double[] a, an array to find the Median from
        *return double the median of a
        */
        public double Median(double[] a)
        {
            double result;
            int middle = a.Length / 2;
            Array.Sort(a);

            //in case array is even take average of the 2 middle position
            if (middle % 2 == 0)
            {
                result = (a[middle] + a[middle - 1]) / 2;
            }
            //when odd, the middle term
            else
            {
                result = a[middle];
            }

            return (result);
        }
        /*
        *param double[] a, an array to find the mean from
        *return double the mean of a
        */
        public double Mean(double[] a)
        {
            double result = 0;
            //sum the terms of the array
            for (int i = 0; i < a.Length; i++)
            {
                result += a[i];
            }

            //return sum divided by ammount of terms
            return (result / a.Length);
        }
    }
}
