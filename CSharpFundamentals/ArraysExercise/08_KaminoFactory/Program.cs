namespace _08_KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <  array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] + array[j] == sum && j > i && j != i)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");

                    }
                }
            }
        }
    }
}