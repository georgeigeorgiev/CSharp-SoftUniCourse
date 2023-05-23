using System.Collections.Generic;
using System.Diagnostics.SymbolStore;

namespace _04_PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());

            int end = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
                sum = sum + i;
                
            }

            Console.Write($"\nSum: {sum}");

        }
    }
}