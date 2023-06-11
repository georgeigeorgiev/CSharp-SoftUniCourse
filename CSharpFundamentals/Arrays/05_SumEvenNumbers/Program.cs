namespace _05_SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < numberInput.Length; i++)
            {
                if (numberInput[i] % 2 == 0)
                {
                    sum += numberInput[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}