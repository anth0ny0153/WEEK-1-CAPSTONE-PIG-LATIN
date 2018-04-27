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
            string part1;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.Write("Please enter a line to be translated: ");
            string userInput = Console.ReadLine();
            int index = userInput.ToLower().IndexOfAny(vowels);
            part1 = userInput.Split(vowels)[0];

            if (index == 0)
            {
                Console.WriteLine(userInput + "way");
            }
            else
            {
                userInput = userInput.Replace(userInput.Split(vowels)[0], "");
                Console.WriteLine(userInput + part1 + "ay");
            }
        }
    }
}
