using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK1CAPSTONE
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                string part1;
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                string userInput = GetInput();
                int index = userInput.ToLower().IndexOfAny(vowels);
                part1 = userInput.Split(vowels)[0];

                if (index == 0)
                {
                    Console.WriteLine(userInput + "way");
                }
                else if (index == -1)
                {
                    Console.WriteLine("Invalid Input. Please try again.");
                }
                else
                {
                    userInput = userInput.Replace(userInput.Split(vowels)[0], "");
                    Console.WriteLine(userInput + part1 + "ay");
                }
                repeat = Confirm("Do you want to continue?(y/n): ");
            }
        }
        public static string GetInput()
        {
                string userInput;
                Console.WriteLine("Welcome to the Pig Latin Translator!");
                Console.Write("Please enter a line to be translated: "); 
                userInput = Console.ReadLine();
                return userInput;
        }
        public static bool Confirm(string message) //method for yes or no questions
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (input.ToLower() == "y") //continues program
            {
                return true;
            }
            else if (input.ToLower() == "n") //closes program
            {
                return false;
            }
            else //invalid input
            {
                Console.WriteLine("Invalid input.");
                return Confirm(message);
            }
        }
    }
}
