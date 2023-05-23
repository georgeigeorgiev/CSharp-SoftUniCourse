using System.ComponentModel.DataAnnotations;

namespace _09_CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = Console.ReadLine()[0];
            char secondChar = Console.ReadLine()[0];
            char thirdChar = Console.ReadLine()[0];

           

            Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");



        }
    }
}