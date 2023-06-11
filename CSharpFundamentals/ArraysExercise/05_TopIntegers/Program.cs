using System.Globalization;

namespace _05_TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int counter = 0;
            int finalArrayLength = 0;
            
            int[] output = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        counter++;

                        if (counter >= array.Length - i - 1)
                        {
                            output[i] = array[i];
                            finalArrayLength++;
                            
                        }
                    }

                   
                }

                counter = 0;
            }

            output[output.Length - 1] = array[array.Length - 1];

            int[] finalArray = new int[finalArrayLength + 1];

            int nextNumber = 0;

            for (int k = 0; k < output.Length; k++)
            {
                if (output[k] != 0)
                {
                    finalArray[nextNumber] = output[k];
                    nextNumber++;
                }
            }

            foreach (int numbers in finalArray)
            {
                Console.Write($"{numbers} ");
            }
        }
    }
}