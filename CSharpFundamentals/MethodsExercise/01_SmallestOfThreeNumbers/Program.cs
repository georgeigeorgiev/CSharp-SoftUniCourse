namespace _01_SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());

            int secondNumber = int.Parse(Console.ReadLine());

            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(firstNumber, secondNumber, thirdNumber));
        }

        static int SmallestNumber(int a, int b, int c)
        {
            int maxNumber = int.MaxValue;

            if (a < maxNumber)
            {
                maxNumber = a;
            }

            if (b < maxNumber)
            {
                maxNumber = b;
            }

            if (c < maxNumber)
            {
                maxNumber = c;
            }

            return maxNumber;
        }
    } 
}