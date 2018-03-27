using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05c
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 2, 4, 6, 8, 10 };
            int[] b = { 1, 3, 5, 7, 9 };
            int[] c = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            RotateArray(0,2,b);
            //rotate left if dir == 0 or right == 1
            //place == number of places to locate

            void RotateArray( int dir, int place, int[] p)
            {
                int[] Result = new int[p.Length];
                for (int i = 0; i < p.Length; i++)
                {
                    int pos = (i + 2) % p.Length;
                    Result[i] = p[pos];
                }
                foreach (int e in Result)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
