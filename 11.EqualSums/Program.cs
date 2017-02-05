using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            long leftSum = 0;
            long rightSum = 0;
            
            int position = 0;
            bool doesntExist = false;

            if (numbers.Count == 1)
            {
                Console.WriteLine(position);
            }
            else
            {
                for (int index = 0; index < numbers.Count; index++)
                {
                    for (int goLeft = index - 1; goLeft >= 0; goLeft--)
                    {
                        leftSum += numbers[goLeft];
                    }
                    for (int goRight = index + 1; goRight < numbers.Count; goRight++)
                    {
                        rightSum += numbers[goRight];
                    }

                    if (leftSum == rightSum)
                    {
                        position = index;
                        Console.WriteLine(position);
                        doesntExist = false;
                        break;
                    }
                    else
                    {
                        leftSum = 0;
                        rightSum = 0;
                        doesntExist = true;
                    }
                }
            }

            if (doesntExist) Console.WriteLine("no");
        }
    }
}
