using System;
using System.IO;
using static System.Console;
using static System.Environment;
using static System.IO.Path;
using CalculatorLib;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string inputPath = Combine(CurrentDirectory, "Input.txt");
            string outputPath = Combine(CurrentDirectory, "Output.txt");
            StreamReader inputText = new StreamReader(inputPath);
            StreamWriter outputText = File.CreateText(outputPath);
            double[] values = new double[25];
            double meanResult, medianResult;
            int position = 0;

            using (inputText)
            {
                while (inputText.Peek() >= 0)
                {
                    values[position] = Convert.ToDouble(inputText.ReadLine());
                    position++;
                }
            }

            var calc = new Calculator();

            medianResult = calc.Median(values);
            meanResult = calc.Mean(values);

            inputText.Close(); // release resources
            outputText.Close();              
            WriteLine("success");
        }
    }
}
