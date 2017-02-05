using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstInput = Console.ReadLine().ToLower().Split(' ').Select(char.Parse).ToArray();
            char[] secondInput = Console.ReadLine().ToLower().Split(' ').Select(char.Parse).ToArray();

            switch (OutPut(firstInput, secondInput))
            {
                case 0:
                    Console.WriteLine(string.Join("", firstInput));
                    Console.WriteLine(string.Join("", secondInput));
                    break;
                case 1:
                    Console.WriteLine(string.Join("", secondInput));
                    Console.WriteLine(string.Join("", firstInput));
                    break;
            }
        }
        
        static int OutPut(char[] firstInput, char[] secondInput)
        {
            int smallerArrayCount = Math.Min(firstInput.Length, secondInput.Length);
            
            for (int i = 0; i < smallerArrayCount; i++)
            {
                if (Convert.ToChar(firstInput[i]) < Convert.ToChar(secondInput[i]))
                {
                    return 0;
                }
                else if (Convert.ToChar(firstInput[i]) > Convert.ToChar(secondInput[i]))
                {
                    return 1;
                }
            }

            if (firstInput.Length > secondInput.Length)
                return 1;

            return 0;
        }
    }
}
