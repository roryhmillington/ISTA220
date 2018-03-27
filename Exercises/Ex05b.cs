using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05b
  {
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 2, 4, 6, 8, 10 };
            int[] b = { 1,3,5,7,9};
            int[] c = { 3,1,4,1,5,9,2,6,3,5,9};
        
            void revarray(int[] p)
            {
                int[] d = new int[p.Length];
                for (int i = 0; i < p.Length; i++)
                {
                    int j = (p.Length - i);
                    d[i] = p[--j];
                }

                foreach(int e in d)
                {
                    Console.WriteLine(e);
                }
            }
            revarray(c);
            {

            }
        }
    }
}
