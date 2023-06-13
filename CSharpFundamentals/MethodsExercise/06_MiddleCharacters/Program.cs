namespace _06_MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = String.Join("", MiddleCharacters(input));

            Console.WriteLine(result);

        }

        static char[] MiddleCharacters(string input)
        {
            if (input.Length % 2 != 0)
            {
                double length = Math.Floor((double)input.Length / 2);
                char[] inputResult = { input[(int)length] };

                return inputResult;
            }

            else if (input.Length % 2 == 0)
            {
                int length = input.Length / 2;
                char[] inputResult = { input[length - 1], input[length] };
                return inputResult;
            }

            else
            {
                return null;
            }
        }
    }
}