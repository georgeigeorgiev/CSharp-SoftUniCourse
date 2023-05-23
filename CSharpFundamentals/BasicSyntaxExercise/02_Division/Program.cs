namespace _02_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int a = number % 2;
            int b = number % 3;
            int c = number % 6;
            int d = number % 7;
            int e = number % 10;

            int division = 0;

            if (a == 0)
            {
                division = 2;
            }

            if (b == 0)
            {
                division = 3;
            }

            if (c == 0)
            {
                division = 6;
            }

            if (d == 0)
            {
                division = 7;
            }

            if (e == 0)
            {
                division = 10;
            }

            if (a != 0 && b != 0 && c != 0 && d != 0 && e != 0)
            {
                Console.WriteLine("Not divisible");
                return;
            }

            Console.WriteLine($"The number is divisible by {division}");

           
        }
    }
}