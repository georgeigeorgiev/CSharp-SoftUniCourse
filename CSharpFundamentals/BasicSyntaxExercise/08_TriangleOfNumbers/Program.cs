using System.Globalization;

namespace _08_TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int i, j, k;
            for (i = 1; i <= n; i++)
            {
                for (k = 1; k <= i; k++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine("");
            }
        }
    }
}