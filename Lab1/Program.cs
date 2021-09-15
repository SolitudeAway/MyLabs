using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chilo = 0;
            chilo = Convert.ToInt32(Console.ReadLine());
            int t = chilo / 100;
            chilo = (chilo - t * 100) * 10 + t;
            Console.WriteLine(chilo);
        }
    }
}
