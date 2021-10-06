using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = 0;
            chislo = Convert.ToInt32(Console.ReadLine());
            int t = chislo / 100;
            chislo = (chislo - t * 100) * 10 + t;
            Console.WriteLine(chislo);
        }
    }
}
