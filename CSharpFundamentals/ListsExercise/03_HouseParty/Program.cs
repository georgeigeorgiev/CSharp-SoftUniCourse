using System.Threading.Channels;

namespace _03_HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            List<string> nameList = new List<string>();

            for (int i = 0; i < input; i++)
            {
                string partyList = Console.ReadLine();

                string[] names = partyList.Split();

                if (names[2] != "not" && nameList.Contains(names[0]) == false)
                {
                    nameList.Add(names[0]);
                }

                else if (names[2] != "not" && nameList.Contains(names[0]) == true)
                {
                    Console.WriteLine($"{names[0]} is already in the list!");
                }

                if (names[2] == "not" && nameList.Contains(names[0]) == false)
                {
                    Console.WriteLine($"{names[0]} is not in the list!");
                }

                else if (names[2] == "not" && nameList.Contains(names[0]) == true)
                {
                    nameList.Remove(names[0]);

                }

            }

            foreach (string names in nameList)
            {
                Console.WriteLine(names);
            }
        }
    }
}