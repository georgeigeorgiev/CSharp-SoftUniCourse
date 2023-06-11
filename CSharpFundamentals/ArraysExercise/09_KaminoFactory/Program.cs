namespace _09_KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            string[] dNA = new string[length];

            int bestSequenceLine = 0;
            int bestSequenceSum = 0;
            int counter = 0;
            int index = 0;
            int bestSequence = 0;
           

            while (input != "Clone them!")
            {
                dNA = input.Split("!");

                for (int i = 0; i < length; i++)
                {
                    counter = 1;
                    

                    for (int j = i + 1; j < length; j++)
                    {
                        if (dNA[i] == dNA[j] && dNA[i] == "1")
                        {
                            counter++;

                            if (counter > bestSequence)
                            {
                                bestSequence = counter;
                                index = i;
                                                          
                                
                            }

                            else if (counter == bestSequence && index > j - counter)
                            {
                                bestSequence = counter;
                                index = i;
                            }
                        }

                        else
                        {
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(index);
            Console.WriteLine(bestSequenceLine);

        }
    }
}
