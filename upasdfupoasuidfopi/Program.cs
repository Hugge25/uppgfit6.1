using System;
using System.Diagnostics.CodeAnalysis;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"6 + 9 + 4 = {Addera(6, 9, 4)}");
        }
        static int Addera(int tal1, int tal2, int tal3)
        {
            int sum = tal1 + tal2 + tal3;
            return sum;
        }
    }
}
