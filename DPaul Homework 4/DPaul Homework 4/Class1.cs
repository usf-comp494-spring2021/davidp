using System;

namespace DPaul_Homework_4
{
    public class Computer
    {

        //Fields
        public string manufacture, model, purposeCode, CPUCode;

        //Methods
        //Parameterized Constructor
        public Computer(string PCManufacture, string PCModel, string PCPurposeCode, string PCCPUCode)
        {
            this.manufacture = PCManufacture;
            this.model = PCModel;
            this.purposeCode = PCPurposeCode;
            this.CPUCode = PCCPUCode;
        }

        //Writes computer information to the screen
        public void WriteToConsole()
        {
            Console.WriteLine($"Computer {model} is made by {manufacture}/n" +
                $"It's CPU code is {CPUCode}, and it's purpose code is {purposeCode}");
        }
    }
    public class Laptop : Computer
    {
        //fields
        public string screenSize;

        //methods
        //Parameterized Constructor
        public Laptop(string screenSize, string manufacture, string model, string purposeCode, string cPUCode) : base(manufacture, model, purposeCode, cPUCode)
        {
            this.screenSize = screenSize;
        }

        //Writes laptop computer information to the screen
        public new void WriteToConsole()
        {
            Console.WriteLine($"Laptop {model} is made by {manufacture}. " +
                $"It's CPU code is {CPUCode}, and it's purpose code is {purposeCode}. " +
                $"It has a screen size of {screenSize}.");
        }
    }
    public class Server : Computer
    {
        //fields
        public string CPUCount;

        //methods
        //Parameterized Constructor
        public Server(string CPUCount, string manufacture, string model, string purposeCode, string cPUCode) : base(manufacture, model, purposeCode, cPUCode)
        {
            this.CPUCount = CPUCount;
        }

        //Writes server computer information to the screen
        public new void WriteToConsole()
        {
            Console.WriteLine($"Server {model} is made by {manufacture}. " +
                $"It's CPU code is {CPUCode}, and it's purpose code is {purposeCode}. " +
                $"It has a {CPUCount} CPUs.");
        }
    }
}
