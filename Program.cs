using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var t = new tests1();

            // Простое число
            int[] x = { 17, 29, 43, 14, 25, 36 };
            foreach (int i in x)   task1(i);


        }

        static void task1(int n)
        {
            int d=0;
            for (int i=2; i<n; i++)
            {
                if (n%i==0) d++;
            }
            if (d == 0) Console.WriteLine($" {n} простое");
            else Console.WriteLine($" {n} НЕ простое");
        }
    }
}
