namespace _11_MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());

            char operation = char.Parse(Console.ReadLine());

            double secondNumber = double.Parse(Console.ReadLine());

            double result = Operator(operation, firstNumber, secondNumber);

            Console.WriteLine(result);


        }

        static double Division(double a, double b)
        {
            return a / b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Operator(char operation, double a, double b)
        {
            double result = 0;

            if (operation == '*')
            {
               result = Multiply(a, b);
            }

            else if (operation == '/')
            {
                result = Division(a, b);
            }

            else if (operation == '-')
            {
                result = Subtract(a, b);
            }

            else if (operation == '+')
            {
                result = Sum(a, b);
            }

            return result;
        }

        
    }
}