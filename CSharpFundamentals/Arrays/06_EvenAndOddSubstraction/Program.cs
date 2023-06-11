namespace _06_EvenAndOddSubstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int even = 0;
            int odd = 0;

            for (int i = 0; i < numberInput.Length; i++)
            {
                if (numberInput[i] % 2 == 0)
                {
                    even += numberInput[i];
                }

                else if (numberInput[i] % 2 != 0)
                {
                    odd += numberInput[i];
                }
            }

            Console.WriteLine(even - odd);
        }
    }
}