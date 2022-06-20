using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class tests1
    {
        public tests1()
        {
            //Loop(0, 10);
        }



        int Factorial2(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }

        /// <summary>
        /// Пример. Цикл с помощью рекурсии
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        void Loop(int a, int b)
        {
            Console.WriteLine(a);
            if (a < b)
                Loop(a + 1, b);
        }
    }
}
