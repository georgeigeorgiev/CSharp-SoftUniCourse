namespace _06_ReversedChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = Convert.ToChar(Console.ReadLine());
            char secondChar = Convert.ToChar(Console.ReadLine());
            char thirdChar = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"{thirdChar} {secondChar} {firstChar}");

        }
    }
}