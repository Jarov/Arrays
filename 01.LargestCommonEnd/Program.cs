using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main()
        {
            string[] firstLine = Console.ReadLine().Split();
            string[] secondLine = Console.ReadLine().Split();

            int LeftToRigth = ScanFromLeft(firstLine, secondLine);
            int RightToLeft = ScanFromRight(firstLine, secondLine);

            if (LeftToRigth >= RightToLeft)
                Console.WriteLine(LeftToRigth);
            else if (RightToLeft > LeftToRigth)
                Console.WriteLine(RightToLeft);
            else
                Console.WriteLine("0");
        }

        static int ScanFromLeft(string[] firstLine, string[] secondLine)
        {
            int count = 0;
            int maxCount = 0;

            int smallerLine = Math.Min(firstLine.Length, secondLine.Length);

            for (int i = 0; i < smallerLine; i++)
            {
                if (firstLine[i] == secondLine[i])
                    count++;
                else
                {
                    if (maxCount < count)
                        maxCount = count;
                    count = 0;
                }
                if (maxCount < count)
                    maxCount = count;
            }

            return maxCount;
        }
        static int ScanFromRight(string[] firstLine, string[] secondLine)
        {
            int count = 0;
            int maxCount = 0;

            int largerLine = Math.Max(firstLine.Length, secondLine.Length) - 1;

            if (firstLine.Length > secondLine.Length)
            {
                for (int i = secondLine.Length - 1; i >= 0; i--, largerLine--)
                {
                    if (firstLine[largerLine] == secondLine[i])
                        count++;
                    else
                    {
                        if (maxCount < count)
                            maxCount = count;
                        count = 0;
                    }
                    if (maxCount < count)
                        maxCount = count;
                }
            }
            else
            {
                for (int i = firstLine.Length - 1; i >= 0; i--, largerLine--)
                {
                    if (secondLine[largerLine] == firstLine[i])
                        count++;
                    else
                    {
                        if (maxCount < count)
                            maxCount = count;
                        count = 0;
                    }
                    if (maxCount < count)
                        maxCount = count;
                }
            }

            return maxCount;
        }
    }
}
