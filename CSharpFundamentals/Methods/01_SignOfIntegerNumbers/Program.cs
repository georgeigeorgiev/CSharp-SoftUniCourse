namespace _01_SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PositiveNegativeOrZeroNumber(number);
        }
        static void PositiveNegativeOrZeroNumber(int number)
        {
            if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }

            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }

            else
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        }
    }
}