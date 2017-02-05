using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            int numberIndex = 0;
            int count = 1;
            int maxCount = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int o = i + 1; o < numbers.Count; o++)
                {
                    if (numbers[i] == numbers[o])
                    {
                        count++;
                        i++;

                        if (maxCount < count)
                        {
                            maxCount = count;
                            numberIndex = o;
                        }
                    }
                    else
                    {
                        if (maxCount < count)
                        {
                            maxCount = count;
                            numberIndex = i;
                        }

                        count = 1;
                    }
                }
            }

            Console.WriteLine($"{numbers[numberIndex]}");
        }
    }
}
