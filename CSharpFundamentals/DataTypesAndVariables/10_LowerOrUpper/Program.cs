namespace _10_LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input = Console.ReadLine()[0];

            if (char.IsLower(input))
            {
                Console.WriteLine("lower-case");
            }

            else if (char.IsUpper(input))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}