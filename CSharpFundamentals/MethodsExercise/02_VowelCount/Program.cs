using System.Runtime.InteropServices;

namespace _02_VowelCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            
            int numberOfVowels = NumberOfVowels(sentence);

            Console.WriteLine(numberOfVowels);

        }

        static int NumberOfVowels(string sentence)
        {
            int count = 0;

            char[] vowels = { 'a', 'i', 'u', 'e', 'o', 'A', 'I', 'U', 'E', 'O' };

            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}