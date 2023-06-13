namespace _04_PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                FirstTriangle(1, i);
            }

            for (int j = end - 1; j >= 1; j--)
            {
                FirstTriangle(1, j);
            }
        }

        static void FirstTriangle(int start, int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}