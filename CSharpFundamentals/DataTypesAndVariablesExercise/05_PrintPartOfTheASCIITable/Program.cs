namespace _05_PrintPartOfTheASCIITable
{
    internal class Program
        
    {
        static void Main(string[] args)
        {
            int startRange = int.Parse(Console.ReadLine());
            int finalRange = int.Parse(Console.ReadLine());

            for (int i = startRange; i <= finalRange; i++)
            {
                Console.Write($"{(char)i} ");
            }


        }
    }
}