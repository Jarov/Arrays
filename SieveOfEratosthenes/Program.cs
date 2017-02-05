using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            List<long> numbers = new List<long>();
            bool[] primes = new bool[n + 1];


            for (long i = 0; i <= n; i++)
            {
                numbers.Add(i);
            }

            PrimeNumberes(numbers, primes);

            List<long> PrimesList = new List<long>();
            for (long i = 0; i < primes.LongLength; i++)
            {
                if (primes[i])
                {
                    PrimesList.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", PrimesList));
        }

        static void PrimeNumberes(List<long> numbers, bool[] primes)
        {
            for (long i = 0; i < primes.LongLength; i++)
            {
                primes[i] = true;
            }

            primes[0] = false;
            primes[1] = false;

            for (long i = 2; i < numbers.Count;  i++)
            {
                if (primes[i])
                {
                    for (long o = 2; (o * i) < numbers.Count; o++)
                    {
                        primes[o * i] = false;
                    }
                }
            }
        }
    }
}
