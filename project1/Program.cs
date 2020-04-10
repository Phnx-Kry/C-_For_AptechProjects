using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# program To check if a number given as input is positive or negative.");
            int numb;
            numb = -4;
            Console.WriteLine((numb > 0) ? "Number is Positive" : "Number is Negative");
        }
    }
}
