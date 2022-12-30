using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the First Number");
            int N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int N2 = int.Parse(Console.ReadLine());
            int N3 = 0;
            int p = 0;
            int mul = 1;
            for (N3 = N1 + 1; N3 < N2; N3++)
            {

                for (p = 1; p <= N3 / 2; p++)
                {
                    mul *= N3 % (p + 1);
                }
                if (mul > 0)
                {
                    Console.WriteLine(N3);
                }
                mul = 1;
            }

        }
    }
}
