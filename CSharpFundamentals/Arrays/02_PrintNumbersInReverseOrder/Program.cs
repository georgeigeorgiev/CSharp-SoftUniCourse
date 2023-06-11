namespace _02_PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int originalN = n;

            int[] number = new int[n];

            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());

            }

            for (int j = 0; j < originalN; j++)
            {
                Console.Write($"{number[n-1]} ");
                n--;
            }

        }
    }
}