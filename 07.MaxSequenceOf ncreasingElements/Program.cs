using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.MaxSequenceOf_ncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int count = 1;
            int maxCount = 1;

            int index = 0;
            int maxIndex = 0;

            for (int i = 0; i < Numbers.Count - 1; i++)
            {
                for (int o = i + 1; o < Numbers.Count; o++)
                {
                    if (Numbers[i] < Numbers[o])
                    {
                        index = o;
                        count++;
                        i++;
                         
                        if (count > maxCount)
                        {
                            maxCount = count;
                            maxIndex = index;
                        }
                    }   
                    else
                    {
                        if (count > maxCount)
                        {
                            maxCount = count;
                            maxIndex = index;
                        }

                        count = 1;
                        break;
                    }
                }
            }

            for (int i = maxIndex - (maxCount) + 1; i <= maxIndex; i++)
            {
                Console.Write($"{Numbers[i]} ");
            }
        }
    }
}
