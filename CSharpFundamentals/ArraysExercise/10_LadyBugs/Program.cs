namespace _10_LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] bugIndex = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[size];

            for (int i = 0; i < bugIndex.Length; i++)
            {
                if (bugIndex[i] >= 0 && bugIndex[i] < size)
                {
                    field[bugIndex[i]] = 1;
                }

            }

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                int currentBugIndex = int.Parse(arguments[0]);
                string direction = arguments[1];
                int flyLength = int.Parse(arguments[2]);

                if (currentBugIndex < 0 || currentBugIndex > size - 1 || field[currentBugIndex] == 0)
                {
                    continue;
                }

                field[currentBugIndex] = 0;

                if (direction == "right")
                {
                    int landIndex = currentBugIndex + flyLength;

                    if (landIndex < 0 || landIndex > size - 1)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flyLength;

                            if (landIndex < 0 || landIndex > size - 1)
                            {
                                break;
                            }

                        }

                    }

                    if (landIndex <= size - 1 && field[landIndex] == 0)
                    {
                            field[landIndex] = 1;
                    }

                }

                else if (direction == "left") 
                {

                    int landIndex = currentBugIndex - flyLength;

                    
                    if (landIndex < 0 || landIndex > size - 1)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;

                            if (landIndex < 0 || landIndex > size - 1)
                            {
                                break;
                            }

                        }

                    }
                      
                    if (landIndex >= 0 && field[landIndex] == 0)
                    {
                       field[landIndex] = 1;
                    }
                }


            }
                Console.WriteLine(string.Join(" ", field));
        }
    }
}