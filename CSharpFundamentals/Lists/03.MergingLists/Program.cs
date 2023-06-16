using System.Globalization;

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int length = 0;
            int minLength = 0;

            if (firstList.Count > secondList.Count)
            {
                length = firstList.Count;
                minLength = secondList.Count;
            }

            else if (secondList.Count > firstList.Count)
            {
                length = secondList.Count;
                minLength = firstList.Count;
            }

            List<int> outputList = new List<int>();

            while (minLength < length)
            {

                for (int i = 0; i < minLength; i++)
                {

                    outputList.Add(firstList[i]);
                    outputList.Add(secondList[i]);

                }

                break;
            }

            for (int j = minLength; j < length; j++)
            {
                if (secondList.Count > firstList.Count)
                {

                    outputList.Add(secondList[j]);

                }

                else if (firstList.Count > secondList.Count)
                {
                    outputList.Add(firstList[j]);
                }
            }

            if (firstList.Count == secondList.Count)
            {
                for (int k = 0; k < firstList.Count; k++)
                {
                    outputList.Add(firstList[k]);
                    outputList.Add(secondList[k]);
                }
            }

            Console.WriteLine(string.Join(" ", outputList));
        }
    }
}