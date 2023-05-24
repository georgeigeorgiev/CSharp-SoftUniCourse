namespace _09_SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            uint days = 0;
            long harvest = 0;

            for (int i = startingYield; i >= 100; i -= 10)
            {
                harvest += (long)i;
                days += 1;

                harvest -= 26;
            }

            if (harvest >= 26)
            {
                harvest -= 26;
            }

            else if (harvest < 26 && harvest > 0)
            {
                harvest -= harvest;
            }
            
            Console.WriteLine(days);
            Console.WriteLine(harvest);
        }
    }
}