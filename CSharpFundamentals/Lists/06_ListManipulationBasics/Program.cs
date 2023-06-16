namespace _06_ListManipulationBasics
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

            while (command != "end")
            {
                Add(command, input);
                Remove(command, input);
                RemoveAt(command, input);
                Insert(command, input);
                
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }

        static void Add(string command, List<int> input)
        {
            string[] addCommand = command.Split();

            if (addCommand[0] == "Add")
            {
                input.Add((int.Parse(addCommand[1])));
            }
        }

        static void Remove(string command, List<int> input)
        {
            string[] addCommand = command.Split();

            if (addCommand[0] == "Remove")
            {
                input.Remove((int.Parse(addCommand[1])));
            }
        }

        static void RemoveAt(string command, List<int> input)
        {
            string[] addCommand = command.Split();

            if (addCommand[0] == "RemoveAt")
            {
                input.RemoveAt((int.Parse(addCommand[1])));
            }
        }

        static void Insert(string command, List<int> input)
        {
            string[] addCommand = command.Split();

            if (addCommand[0] == "Insert")
            {
                input.Insert(int.Parse(addCommand[2]), int.Parse(addCommand[1]));
            }
        }
    }
}