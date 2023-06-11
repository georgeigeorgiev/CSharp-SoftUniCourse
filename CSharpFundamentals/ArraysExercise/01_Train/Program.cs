using System.Xml;

namespace _01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] inputArray = new int[input];
            
            

            for (int i = 0; i < input; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                inputArray[i] = passengers;
            }

            int sum = 0;

            for (int j = 0; j < inputArray.Length; j++)
            {

            Console.Write($"{inputArray[j]} ");

                sum += inputArray[j];

            }

            Console.WriteLine("");
            Console.Write(sum);
        }
    }
}