using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = numbers.Length / 2;
            int[] result = new int[k];  //4

            for (int i = 0; i < k / 2; i++)
            {
                result[k / 2 - i - 1] = numbers[i] + numbers[k - i - 1];
                result[k / 2 + i] = numbers[k + i] + numbers[numbers.Length - i - 1];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
