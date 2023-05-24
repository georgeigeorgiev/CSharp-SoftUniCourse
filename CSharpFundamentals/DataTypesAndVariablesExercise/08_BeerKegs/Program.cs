using System.Reflection;
using System.Transactions;

namespace _08_BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());

            double volume = 0;
            double biggestVolumeCheck = 0;
            string biggestModel = null;

            for (int i = 0; i < numberOfKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume += 3.14 * (radius * radius) * height;
                
                if (volume > biggestVolumeCheck)
                {
                    biggestModel = model;
                    biggestVolumeCheck = volume;
                }

               volume = 0;
            }

            Console.WriteLine(biggestModel);
        }
    }
}