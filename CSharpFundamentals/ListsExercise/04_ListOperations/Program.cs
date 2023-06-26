using System.Globalization;

namespace _04_ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {

            }

        }

        static void Add(List<int> numbers, string input)
        {

        }
    }
}