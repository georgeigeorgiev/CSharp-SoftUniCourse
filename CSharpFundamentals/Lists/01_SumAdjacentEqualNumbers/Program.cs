using System.Threading.Channels;

namespace _01_SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            int numberCounter = numbers.Count;

            for (int i = 0; i < numberCounter - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    numberCounter -= 1;
                    i = - 1;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));



        }
    }
}