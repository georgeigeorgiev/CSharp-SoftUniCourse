namespace _02_ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOutput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                Delete(input, listOutput);
                Insert(input, listOutput);

                input = Console.ReadLine();
            }

            foreach (int number in listOutput)
            {
                Console.Write($"{number} ");
            }
        }

        static void Delete(string input, List<int> list)
        {
            string[] newString = input.Split();

            if (newString[0] == "Delete")
            {
                list.Remove(int.Parse(newString[1]));
            }
        }

        static void Insert(string input, List<int> list)
        {
            string[] newString = input.Split();

            if (newString[0] == "Insert")
            {
                list.Insert(int.Parse(newString[2]), int.Parse(newString[1]));
            }
        }
    }
}