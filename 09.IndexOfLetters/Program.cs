using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = Console.ReadLine().ToArray();

            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine($"{letters[i]} -> {(int)(letters[i] - 'a')}");
            }
        }
    }
}
