namespace _05_AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());

            int secondNumber = int.Parse(Console.ReadLine());

            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = SumOfFirstTwoNumbers(firstNumber, secondNumber);

            int result = SubtractThirdNumberFromSum(sum, thirdNumber);

            Console.WriteLine(result);
        }

        static int SumOfFirstTwoNumbers(int a, int b)
        {
            return a + b;
        }

        static int SubtractThirdNumberFromSum(int sum, int c)
        {
            return sum - c;
        }
    }
}