namespace _03_ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < countOfNumbers; i++)
            {
                decimal numberInput = decimal.Parse(Console.ReadLine());

                sum+= numberInput;
            }

            Console.WriteLine(sum);
        }
    }
}