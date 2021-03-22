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
            //Set up input and output files in the current directory
            string inputPath = Combine(CurrentDirectory, "Input.txt");
            string outputPath = Combine(CurrentDirectory, "Output.txt");
            StreamReader inputText = new StreamReader(inputPath);
            StreamWriter outputText = File.CreateText(outputPath);
            
            double[] values = new double[15];
            double meanResult, medianResult;
            int position = 0;

            //read in the input, convert to doubles, and add to the array
            using (inputText)
            {
                while (inputText.Peek() >= 0)
                {
                    values[position] = Convert.ToDouble(inputText.ReadLine());
                    position++;
                }
            }
            
            //calculate mean and median
            var calc = new Calculator();

            medianResult = calc.Median(values);
            meanResult = calc.Mean(values);


            //write output file
            outputText.WriteLine("The median of the input is: {0}\n" +
                "The mean of the input is: {1}",
                arg0: medianResult,
                arg1:meanResult);

            // release resources
            inputText.Close(); 
            outputText.Close();
            
        }
    }
}
