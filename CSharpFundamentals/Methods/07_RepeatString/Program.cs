namespace _07_RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string result = RepeatedString(input, count);

            Console.WriteLine(result);
        }

        private static string RepeatedString(string text, int count)
        {
            string result = "";

            for (int i = 1; i <= count; i++)
            {
                result += text;
            }

            return result;
        }
    }
}