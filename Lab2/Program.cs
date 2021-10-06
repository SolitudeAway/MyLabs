using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            b = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            c = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (a >= c)
            {
                if (b > c)
                    sum = a + b;
                else
                    sum = a + c;
            }
            else if (b >= c)
                sum = b + c;
            else if (a > b)
                sum = a + c;
            else
                sum = b + c;

            Console.WriteLine(sum);
        }
    }
}
