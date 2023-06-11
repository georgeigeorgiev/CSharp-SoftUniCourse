namespace _06_EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isTrue = false;

           for (int i = 0; i < arrayInput.Length; i++)
            {
                int leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += arrayInput[j];

                }

                int rightSum = 0;

                for (int k = arrayInput.Length - 1; k > i; k--)
                {
                    rightSum += arrayInput[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isTrue = true;

                }
            }

           if (!isTrue)
            {
                Console.WriteLine("no");
            }
            


        }
    }
}