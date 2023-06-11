using System.Diagnostics.Metrics;
using System.Reflection;

namespace _07_EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            
            int sum = 0;
            int counter = 0;
            int counterDifference = 0;

            for (int i = 0;  i < firstInput.Length; i++)
            {

                sum += firstInput[i];

                if (firstInput[i] == secondInput[i])
                {
                    counter++;
                }

                else if (firstInput[i] != secondInput[i])
                {
                    counterDifference = i;
                    break;
                }

                
            }
       
                
            if (counter == firstInput.Length)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

            else
            {
                if (counter >= 1 && counter != firstInput.Length)
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {counterDifference} index");
                }

                else if (counter == 0)
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at 0 index");
                }
                        
            }

            
        }
    }
}