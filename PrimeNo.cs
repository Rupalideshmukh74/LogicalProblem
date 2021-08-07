using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProbem
{
    class PrimeNo
    {
        public static void primeno()
        {
            int count = 0;
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i < number; i++)
            {
                if(number%i==0)
                {
                    count++;
                }
            }
            if(count==0)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }
    }
}
