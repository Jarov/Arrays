using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] sum = new int[numbers.Length];
            
            for (int i = 0; i < k; i++ )
            {
                ArrayRotatation(numbers);
                for (int o = 0; o < numbers.Length; o++)
                {
                    sum[o] += numbers[o];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
        static void ArrayRotatation(int[] numbers)
        {
            int lastNumber = numbers.Last();
            for (int o = numbers.Length - 1; o > 0; o--)
            {
                numbers[o] = numbers[o - 1];
            }
            numbers[0] = lastNumber;
        }
    }
}
