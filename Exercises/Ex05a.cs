﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05A
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 2, 4, 6, 8, 10 };
            int[] B= { 1, 3, 5, 7, 9 };
            int[] C = { 3, 1, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            int count = 0;
            int sum = 0;
            double mean = 0.0;
            foreach(int e in A)
            {
                count++;
                sum = e + sum;
               
            }
            mean = (double)sum / count;

            Console.WriteLine($"the count is {count}");
            Console.WriteLine($"the sum is {sum}");
            Console.WriteLine($"the mean is {sum / count}");

        }
    }
}