namespace _04_ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            int length = input.Length;
            

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{input[length - 1]} ");
                length--;
            }





        }
    }
}