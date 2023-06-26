using System.ComponentModel;
using System.Threading.Channels;

namespace _01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                AddPassengers(input, wagons);
                Passengers(maxCapacity, input, wagons);

                input = Console.ReadLine();
            }

            foreach (int numbers in wagons)
            {
                Console.Write($"{numbers} ");
            }
        }

        static void AddPassengers(string input, List<int> wagons)
        {
            string[] wagon = input.Split();

            if (wagon[0] == "Add")
            {
                for (int i = 1; i < wagon.Length; i++)
                {
                    wagons.Add(int.Parse(wagon[i]));
                }
            } 
        }

        static void Passengers(int max, string input, List<int> wagons)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                string[] wagon = input.Split();

                if (wagon[0] != "Add")
                {
                    if (int.Parse(input) + wagons[i] <= max)

                    {

                      wagons[i] += int.Parse(input);
                      break;

                    }

                }
                
            }
        }
    }
}