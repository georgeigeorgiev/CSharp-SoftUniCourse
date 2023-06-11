using System.Globalization;

namespace _08_CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] condensed = new int[numberInput.Length - 1];


            if (numberInput.Length == 1)
            {
                Console.WriteLine(numberInput[0]);
                return;
            }

            for (int i = 0; i < numberInput.Length; i++)
            {
                for (int j = 0; j < condensed.Length - i; j++)
                {
                    condensed[j] = numberInput[j] + numberInput[j + 1];
                }
                numberInput = condensed;
            }
            Console.WriteLine(condensed[0]);

            
        }
    }
}