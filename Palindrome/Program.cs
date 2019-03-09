using System;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var splitInput = input.ToCharArray();
            splitInput = splitInput.Where(letter => (letter != ',') & (letter != '.') & (letter != '!') & (letter != '?') &
            (letter != ' ')).ToArray();
            var counter = 0;
            for (var i = 0; i < splitInput.Length; i++)
            {
                if (Char.ToLower(splitInput[i]) == Char.ToLower(splitInput[splitInput.Length - i - 1]))
                {
                    counter++;
                }
            }
            if (counter == splitInput.Length)
            {
                Console.WriteLine("Its a palindrome.");
            } else
            {
                Console.WriteLine("That ain't a palindrome.");
            }


            Console.ReadLine();
        }
    }
}
