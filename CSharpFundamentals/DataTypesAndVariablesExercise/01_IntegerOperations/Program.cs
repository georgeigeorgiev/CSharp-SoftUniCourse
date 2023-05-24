namespace _01_IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int firstCalculation = firstNumber + secondNumber;
            int secondCalculation = firstCalculation / thirdNumber;
            int thirdCalculation = secondCalculation * fourthNumber;

            Console.WriteLine(thirdCalculation);
        }
    }
}