namespace _08_FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double firstFactorial = FirstNumberFactorial(firstNumber);
            double secondFactorial = SecondNumberFactorial(secondNumber);

            double divisionResult = DivisionOfFactorials(firstFactorial, secondFactorial);
            Console.WriteLine($"{divisionResult:f2}");


        }

        static double FirstNumberFactorial(int firstNumber)
        {
            double result = 1;

            for (int i = firstNumber; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }

        static double SecondNumberFactorial(int secondNumber)
        {
            double result = 1;

            for (int i = secondNumber; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }

        static double DivisionOfFactorials(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}