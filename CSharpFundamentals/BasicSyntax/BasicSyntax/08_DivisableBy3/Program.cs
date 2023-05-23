namespace _08_DivisableBy3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 1;

            for (int i = 1; i < 100; i++)
            {
                x = i * 3; 

                if (x > 100)
                {
                    break;
                }

                Console.WriteLine(x);
            }
        }
    }
}