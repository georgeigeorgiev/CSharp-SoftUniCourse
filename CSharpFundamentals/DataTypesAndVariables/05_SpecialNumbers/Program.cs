using System.Diagnostics.CodeAnalysis;

namespace _05_SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberRange = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberRange; i++)
            {
                int number = i;
                int sum = 0;

                while (number != 0)
                {
                    sum += number % 10;

                    number = number / 10;
                }

                
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }

                else
                {
                    Console.WriteLine($"{i} -> False");
                }

                
            }

            
        }
    }
}