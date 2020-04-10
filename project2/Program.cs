using System;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# program: To take a letter as input and tell whether the letter is a vowel or not.");
            String alphabet;
            Console.WriteLine("Enter Alphabet");
            alphabet = Convert.ToString(Console.ReadLine());
            Boolean conditions = (alphabet != "a") & (alphabet != "e") & (alphabet != "i") & (alphabet != "o") & (alphabet != "u") & (alphabet != "A") & (alphabet != "E") & (alphabet != "I") & (alphabet != "O") & (alphabet != "U");
            if (conditions) {
                Console.WriteLine("Vovel Absent");
            }else{
                Console.WriteLine("Vowel Present");
            }
        }
    }
}
