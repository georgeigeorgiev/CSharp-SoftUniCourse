namespace _12_EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)

            {
                int number = int.Parse(Console.ReadLine());

                if (Math.Abs(number) % 2 != 0)
                {
                    Console.WriteLine($"Please write an even number.");
                }
                if (Math.Abs(number) % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
            }


        }
    }
}