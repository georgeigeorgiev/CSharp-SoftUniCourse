using System.Drawing;

namespace _09_GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputValue = Console.ReadLine();

            string result = null;

            
            switch (inputValue)
            {
                case "string":
                    string a = Console.ReadLine();
                    string b = Console.ReadLine();
                    result = GetMax(a, b);
                    break;

                case "char":
                    char c = char.Parse(Console.ReadLine());
                    char d = char.Parse(Console.ReadLine());
                    result = GetMax(c, d).ToString();
                    break;

                case "int":
                    int e = int.Parse(Console.ReadLine());
                    int f = int.Parse(Console.ReadLine());
                    result = GetMax(e, f).ToString();
                    break;

            }

            
            

            Console.WriteLine(result);


        }

        static int GetMax(int a, int b)
        {
            int result;

            if (a > b)
            {
                result = a;
            }

            else
            {
                result = b;
            }

            return result;
        }

        static string GetMax(string a, string b)
        {
            string result;
            int compareStrings = a.CompareTo(b);

            if (compareStrings > 0)
            {
                result = a;
            }

            else
            {
                result = b;
            }

            return result;
        }

        static char GetMax(char a, char b)
        {
            char result;

            if (a > b)
            {
                result = a;
            }

            else
            {
                result = b;
            }

            return result;
        }
    }
}