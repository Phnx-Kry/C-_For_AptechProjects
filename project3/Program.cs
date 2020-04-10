using System;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# program: Take a number (1-12) as input and return the respective Month for that number.");
            int month;
            Console.WriteLine("Enter Digits b/w  1 - 12 ");
            month = Convert.ToInt32(Console.ReadLine());

            if(month == 1){
                Console.WriteLine("January");
            }else if (month == 2){
                Console.WriteLine("Febuary");
            }else if (month == 3){
                Console.WriteLine("March");
            }else if (month == 4){
                Console.WriteLine("April");
            }else if (month == 5){
                Console.WriteLine("May");
            }else if (month == 6){
                Console.WriteLine("June");
            }else if (month == 7){
                Console.WriteLine("July");
            }else if (month == 8){
                Console.WriteLine("August");
            }else if (month == 9){
                Console.WriteLine("September");
            }else if (month == 10){
                Console.WriteLine("October");
            }else if (month == 11){
                Console.WriteLine("November");
            }else if (month == 12){
                Console.WriteLine("December");
            }else {
                Console.WriteLine("Enter Valid Number");
            }
        }
    }
}
