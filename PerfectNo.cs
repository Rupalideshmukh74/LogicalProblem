using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProbem
{
    class PerfectNo
    {

        public static void perfectno()
        {
             int sum = 0;
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                if (number % i == 0)
                    sum =sum + i;
            }
            if(sum==number)
            {
                Console.WriteLine("It is Perfect number");
            }
            else
            {
                Console.WriteLine("It is not Perfect number");
            }

        }
    }
}
