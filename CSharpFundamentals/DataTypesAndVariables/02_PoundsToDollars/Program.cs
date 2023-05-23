namespace _02_PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal dollar = decimal.Parse(Console.ReadLine());

            decimal pound = dollar * 1.31M;

            Console.WriteLine($"{pound:F3}");

        }
    }
}