namespace _04_SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int totalSum = 0;

            for (int i = 0; i < input; i++)
            {
                char charInput = Console.ReadLine()[0];

                totalSum += charInput;

            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}