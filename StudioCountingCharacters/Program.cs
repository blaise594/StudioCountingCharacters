using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> Counts = new Dictionary<char, int>();
            Console.WriteLine("Please enter a phrase");
            string babel = Console.ReadLine();
            char[] characters = babel.ToCharArray();
            foreach (char character in characters)
            {
                if (Counts.ContainsKey(character))
                {
                    Counts[character] = Counts[character] + 1;
                }
                else
                {
                    Counts.Add(character, 1);
                }

            }
            foreach (KeyValuePair<char, int> Count in Counts)
            {
                Console.WriteLine("There are " + Count.Value + " of " + Count.Key);
            }
            Console.ReadLine();
        }

    }
}