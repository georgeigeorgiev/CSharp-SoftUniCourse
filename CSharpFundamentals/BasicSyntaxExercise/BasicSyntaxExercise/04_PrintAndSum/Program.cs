using System.Collections.Generic;
using System.Diagnostics.SymbolStore;

namespace _04_PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will receive two whole numbers from the console representing the start and the end of a sequence of numbers.

            int start = int.Parse(Console.ReadLine());

            int end = int.Parse(Console.ReadLine());

            int sum = 0;

            //Your task is to print two lines:
            //• On the first line, print all numbers from the start of the sequence to the end inclusive.
            //• On the second line, print the sum of the sequence in the format: "Sum: {sum}".

            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
                sum = sum + i;
                
            }

            Console.Write($"\nSum: {sum}");

        }
    }
}