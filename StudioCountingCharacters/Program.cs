using System;
using System.Collections.Generic;
using System.Linq;

namespace StudioCountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> Counts = new Dictionary<char, int>();
            String babel= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            char[] characters = babel.ToCharArray();

            foreach(char character in characters)
            {
                if(Counts.ContainsKey(character))
                {
                    Counts[character] = Counts[character] + 1;
                }
                else
                {
                    Counts.Add(character, 1);
                }
                foreach(KeyValuePair<char, int> Count in Counts)
                {
                    Console.WriteLine("There are " + Count.Value+ " of "+ Count.Key);
                }
                Console.ReadLine();
            }
        }
    }
}
