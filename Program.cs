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

            // Простое число
            TestCase mainTester = new TestCase();
            List<TestCase> tests = new List<TestCase>();

            tests.Add(new TestCase() { X = 17, ExpectedS = "y" });
            tests.Add(new TestCase() { X = 29, ExpectedS = "y" });
            tests.Add(new TestCase() { X = 43, ExpectedS = "y" });
            tests.Add(new TestCase() { X = 14, ExpectedS = "n" });  //не простое
            tests.Add(new TestCase() { X = 25, ExpectedS = "n" });  //не простое

            Console.WriteLine("     Простое число");
            foreach (TestCase testCase in tests)
            {
                mainTester.TestSimpleNumber(testCase);
            }
            tests.Clear();



            //числа Фибоначчи
            // 0	1	2	3	4	5	6	7   9   10
            // 0	1	1	2	3	5	8	13  34  55
            tests.Add(new TestCase() { X = 0, ExpectedI = 0 });
            tests.Add(new TestCase() { X = 2, ExpectedI = 1 });
            tests.Add(new TestCase() { X = 4, ExpectedI = 3 });
            tests.Add(new TestCase() { X = 7, ExpectedI = 13 });
            tests.Add(new TestCase() { X = 9, ExpectedI = 33 });    // must be 34
            tests.Add(new TestCase() { X = 10, ExpectedI = 54 });   // must be 55

            Console.WriteLine("\n \n   числа Фибоначчи");
            foreach (TestCase testCase in tests)
            {
                mainTester.TestFiboRecursive(testCase);
                mainTester.TestFiboCycleFor(testCase);
            }
            tests.Clear();


            Console.ReadLine();

        }

        static public string SimpleNumber(int n)
        {
            int d=0;
            for (int i=2; i<n; i++)
            {
                if (n%i==0) d++;
            }
            if (d == 0) { Console.WriteLine($" {n} простое"); return "y"; }
            else {Console.WriteLine($" {n} НЕ простое"); return "n"; }
        }

        static int StrangeSum(int[] inputArray)   // O(n^3)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++) // n
            {
                for (int j = 0; j < inputArray.Length; j++) // n*n
                {
                    for(int k = 0; k < inputArray.Length; k++)          // n*n*n              
                    {
                        int y = 0;
                        if (j != 0)
                        {
                            y = k / j;
                        }
                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }
            return sum;
        }

        static public int F_recurse(int x)
        {
            int result;
            switch (x)
            {
                case 0:
                    result = 0;
                    break;
                case 1:
                    result = 1;
                    break;
                default:result = F_recurse(x - 1) + F_recurse(x - 2); 
                    break;
            }
            return result;

        }
        static public int F_for(int x)
        {
            int f_1 = 0; int f_2 = 0;
            int r = 0;

            for (int k=0; k<=x; k++)
            {

                switch (k)
                {
                    case 0:
                        f_1 = 0; f_2 = 0;
                        r = 0;
                        break;
                    case 1:
                        f_1 = 1; f_2 = 0;
                        r = 1;
                        break;
                    default:
                        r = f_1 + f_2;
                        f_2 = f_1;
                        f_1 = r;                        
                        break;
                }
            }

            return r;
        }


    }
}
