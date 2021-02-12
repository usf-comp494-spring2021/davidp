using System;

namespace DPaul_Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an array of ints
            int[] numbers;
            numbers = new int [] { 1, 2, 3, 4, 5, 11, 12, 13, 14, 15 };
            foreach (int i in numbers)
            {
                //using mod 2 if it returns 0 the number is even
                if (i % 2 == 0)
                    Console.WriteLine("{0} is even", i);
                //else it is odd
                else 
                    Console.WriteLine("{0} is odd", i);
            }
        }
    }
}
