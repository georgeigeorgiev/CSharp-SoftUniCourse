using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _05_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            char[] stringArray = username.ToCharArray();
            Array.Reverse(stringArray);
            string truePassword = new string(stringArray);

          
            for (int i = 1; i < 4; i++)
            {
                if (truePassword != password)
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                    password = Console.ReadLine();
                }

                else if (truePassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
            }

            Console.WriteLine($"User {username} blocked!");
            

        }
    }
}