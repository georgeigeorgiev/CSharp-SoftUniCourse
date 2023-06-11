namespace _07_MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bestSequence = 0;
            int counter = 0;
            int sequenceNumber = 0;

            for (int i = 0; i < input.Length; i++)
            {
                counter = 1;

                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        counter++;
                        
                        if (bestSequence < counter)
                        {
                            bestSequence = counter;
                            sequenceNumber = input[i];
                        }

                        
                    }

                    else
                    {
                        break;
                    }
                }


            }

            for (int k = 0; k < bestSequence; k++)
            {
                Console.Write($"{sequenceNumber} ");
            }
        }
    }
}