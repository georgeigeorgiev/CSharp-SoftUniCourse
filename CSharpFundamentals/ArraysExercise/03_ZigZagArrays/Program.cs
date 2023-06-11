namespace _03_ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] firstArray = new int[input];
            int[] secondArray = new int[input];

            for (int i = 0; i < input;  i++)
            {
                int[] numberInput = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i == 0 || i % 2 == 0)
                {
                    firstArray[i] = numberInput[0];

                    secondArray[i] = numberInput[1];
                }

                else
                {
                    firstArray[i] = numberInput[1];

                    secondArray[i] = numberInput[0];
                }

                

            }

            foreach (var number in firstArray)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine("");

            foreach (var number in secondArray)
            {
                Console.Write($"{number} ");
            }
            
        }
    }
}