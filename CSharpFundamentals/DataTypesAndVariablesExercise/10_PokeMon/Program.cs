namespace _10_PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int originalPokePower = pokePower;
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokeCounter = 0;
            
            while (pokePower >= distance)
            {
                pokeCounter++;

                pokePower -= distance;

                if (pokePower == originalPokePower / 2 && pokePower > exhaustionFactor && pokePower != 0 && exhaustionFactor != 0)
                {
                    pokePower = pokePower / exhaustionFactor;
                }

            }

            
            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCounter);
            

        }
    }
}