namespace _02_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Finish")
            {
                Add(input, numbers);
                Remove(input, numbers);
                Replace(input, numbers);
                Collapse(input, numbers);

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void Add(string input, List<int> numbers)
        {
            string[] newInput = input.Split();

            if (newInput[0] == "Add")
            {
                numbers.Add(int.Parse(newInput[1]));
            }
        }

        static void Remove(string input, List<int> numbers)
        {
            string[] newInput = input.Split();

            if (newInput[0] == "Remove")
            {
                numbers.Remove(int.Parse(newInput[1]));
            }
        }

        static void Replace(string input, List<int> numbers)
        {
            string[] newInput = input.Split();

            if (newInput[0] == "Replace")
            {
               int index = numbers.FindIndex(s => s == int.Parse(newInput[1]));

               if (index != -1)
               {
                   numbers[index] = int.Parse(newInput[2]);
               }
            }
        }

        static void Collapse(string input, List<int> numbers)
        {
            string[] newInput = input.Split();
            int numbersCount = numbers.Count;

            if (newInput[0] == "Collapse")
            {
                for (int i = 0; i < numbersCount; i++)
                {
                    if (numbers[i] < int.Parse(newInput[1]))
                    {
                        numbers.Remove(numbers[i]);
                        numbersCount = numbers.Count;
                        i = -1;
                        

                    }
                }
            }
        }
    }
}