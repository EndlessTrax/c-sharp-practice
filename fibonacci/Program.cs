using System;
using System.Collections.Generic;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = new List<int> { 1, 1 }; // Starting numbers

            while (sequence.Count < 20) // Firts 20 number of fib
            {
                int previous = sequence[sequence.Count - 1];
                int previous2 = sequence[sequence.Count - 2];

                sequence.Add(previous + previous2);
            }

            foreach (int number in sequence)
            {
                Console.WriteLine(number);
            }
        }
    }
}
