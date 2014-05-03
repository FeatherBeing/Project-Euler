﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler2
{
    class Program
    { 
        // Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
        // By starting with 1 and 2, the first 10 terms will be:
        // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        static void Main(string[] args)
        {
            // Okay this one is a little bit trickier ... 
            Console.WriteLine(GetFibonacciSequence().Where(n => n % 2 == 0).Sum());
            Console.ReadKey();
        }

        //Returns a Fibonacci sequence with the value of terms from 1 to 4,000,000
        static long[] GetFibonacciSequence()
        {
            int n = 0;
            var numbers = new List<long>();

            while (true)
            {
                numbers.Add(GetFibonacciNumber(n++));
                if (numbers.Last() >= 4000000)
                {
                    numbers.RemoveAt(numbers.Count - 1);
                    break;
                }
            }

            return numbers.ToArray();
        }

        static int GetFibonacciNumber(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            if (n == 1) 
            {
                return 1;
            }

            return GetFibonacciNumber(n - 1) + GetFibonacciNumber(n - 2);
        }
    }
}