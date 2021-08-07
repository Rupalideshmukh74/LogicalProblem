using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProbem
{
    class FibonacciSeries
    {
        public static void fibonacciSeries()
       {
            int a = 0, b = 1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                Console.WriteLine((i+3)+" "+c);
                a = b;
                b = c;
            }

            Console.ReadLine();
        }
    }
}   
 
