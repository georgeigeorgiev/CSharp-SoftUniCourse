using System.Threading.Channels;

namespace _02_Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> numberOutput = new List<int>();

            if (numberInput.Count % 2 != 0)
            {

                for (int i = 0; i < Math.Ceiling(((double)numberInput.Count / 2) - 1); i++)
                {
                    numberOutput.Add(numberInput[i] + numberInput[numberInput.Count - 1 - i]);
                }

                numberOutput.Add(numberInput[(int)Math.Floor((double)numberInput.Count / 2)]);
            }


            if (numberInput.Count % 2 == 0)
            {
                for (int i = 0; i < Math.Ceiling(((double)numberInput.Count / 2)); i++)
                {
                    numberOutput.Add(numberInput[i] + numberInput[numberInput.Count - 1 - i]);
                }

            }
            

            Console.WriteLine(string.Join(" ", numberOutput));

        }
    }
}