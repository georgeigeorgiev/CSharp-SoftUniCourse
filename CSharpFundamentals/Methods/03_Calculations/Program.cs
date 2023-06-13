namespace _03_Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int firstInput = int.Parse(Console.ReadLine());

            int secondInput = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(firstInput, secondInput);
                    break;

                case "subtract":
                    Subtract(firstInput, secondInput);
                    break;

                case "multiply":
                    Multiply(firstInput, secondInput);
                    break;

                case "divide":
                    Divide(firstInput, secondInput);
                    break;
            }
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}