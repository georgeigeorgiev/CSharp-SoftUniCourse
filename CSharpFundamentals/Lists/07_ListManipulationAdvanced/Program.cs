namespace _07_ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            

            string command = Console.ReadLine();

            int counter = 0;

            
            while (command != "end")
            {
                if (Add(command, input) == true)
                {
                    counter++;
                }

                if (Remove(command, input) == true)
                {
                    counter++;
                }

                if (RemoveAt(command, input) == true)
                {
                    counter++;
                }

                if (Insert(command, input) == true)
                {
                    counter++;
                }
                Contains(command, input);
                PrintEven(command, input);
                PrintOdd(command, input);
                GetSum(command, input);
                Filter(command, input);

                command = Console.ReadLine();
            }

            if (counter > 0)
            {
                Console.WriteLine(string.Join(" ", input));
            }

            
        }

        static void Contains(string command, List<int> input)
        {
            string[] addCommand = command.Split();

            if (addCommand[0] == "Contains")
            {
                if (input.Contains(int.Parse(addCommand[1])))
                {
                    Console.WriteLine("Yes");
                }

                else
                {
                    Console.WriteLine("No such number");
                }
            }
        }

        static void PrintEven(string command, List<int> input)
        {
            if (command == "PrintEven")
            {
                foreach (int number in input)
                {
                    if (number % 2 == 0)
                    {
                        Console.Write($"{number} ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void PrintOdd(string command, List<int> input)
        {
            if (command == "PrintOdd")
            {
                foreach (int number in input)
                {
                    if (number % 2 != 0)
                    {
                        Console.Write($"{number} ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void GetSum(string command, List<int> input)
        {
            if (command == "GetSum")
            {
                Console.WriteLine(input.Sum());
            }
        }

        static void Filter(string command, List<int> input)
        {
            string[] addCommand = command.Split();

            if (addCommand[0] == "Filter")
            {
                if (addCommand[1] == "<")
                {
                    foreach (int number in input)
                    {
                        if (number < (int.Parse(addCommand[2])))
                        {
                            Console.Write($"{number} ");
                        }
                    }

                    Console.WriteLine();
                }

                else if (addCommand[1] == ">")
                {
                    foreach (int number in input)
                    {
                        if (number > (int.Parse(addCommand[2])))
                        {
                            Console.Write($"{number} ");
                        }
                    }

                    Console.WriteLine();
                }

                else if (addCommand[1] == ">")
                {
                    foreach (int number in input)
                    {
                        if (number > (int.Parse(addCommand[2])))
                        {
                            Console.Write($"{number} ");
                        }
                    }

                    Console.WriteLine();
                }

                else if (addCommand[1] == ">=")
                {
                    foreach (int number in input)
                    {
                        if (number >= (int.Parse(addCommand[2])))
                        {
                            Console.Write($"{number} ");
                        }
                    }

                    Console.WriteLine();
                }

                else if (addCommand[1] == "<=")
                {
                    foreach (int number in input)
                    {
                        if (number <= (int.Parse(addCommand[2])))
                        {
                            Console.Write($"{number} ");
                        }
                    }

                    Console.WriteLine();
                }
            }
        }

        static bool Add(string command, List<int> input)
        {
            string[] addCommand = command.Split();

            if (addCommand[0] == "Add")
            {
                input.Add((int.Parse(addCommand[1])));
                return true;
            }

            else
            {
                return false;
            }

        }

        static bool Remove(string command, List<int> input)
        {
            string[] addCommand = command.Split();

            if (addCommand[0] == "Remove")
            {
                input.Remove((int.Parse(addCommand[1])));
                return true;
            }

            else
            {
                return false;
            }

        }

        static bool RemoveAt(string command, List<int> input)
        {
            string[] addCommand = command.Split();

            if (addCommand[0] == "RemoveAt")
            {
                input.RemoveAt((int.Parse(addCommand[1])));
                return true;
            }

            else
            {
                return false;
            }

        }

        static bool Insert(string command, List<int> input)
        {
            string[] addCommand = command.Split();

            if (addCommand[0] == "Insert")
            {
                input.Insert(int.Parse(addCommand[2]), int.Parse(addCommand[1]));
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}