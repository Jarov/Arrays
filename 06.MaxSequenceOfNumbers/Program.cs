using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int count = 1;
            int maxCount = 0;
            int currentIndex = 0;
            int maxIndex = 0;

            while (currentIndex < Numbers.Count - 1)
            {
                if (Numbers[currentIndex] == Numbers[currentIndex + 1] - 1)
                {
                    count++;

                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxIndex = currentIndex;
                    }
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxIndex = currentIndex;
                    }

                    count = 1;
                }

                currentIndex++;
            }

            for (int i = maxCount; i > 0; i--)
            {
                Console.Write($"{Numbers[maxIndex - i + 2]} ");
            }
        }
    }
}
