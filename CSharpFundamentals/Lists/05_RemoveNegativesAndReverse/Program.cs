namespace _05_RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> outputNumbers = new List<int>();

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i] >= 0)

                {
                    outputNumbers.Add(inputNumbers[i]);
                }
            }

            if (outputNumbers.Count > 0)
            {
                outputNumbers.Reverse();
                Console.WriteLine(string.Join(" ", outputNumbers));
            }

            else
            {
                Console.WriteLine("empty");
            }


        }
    }
}