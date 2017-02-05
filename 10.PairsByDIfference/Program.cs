using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDIfference
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int difference = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int o = i + 1; o < numbers.Count; o++)
                {
                    if (Math.Abs(numbers[i] - numbers[o]) == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
