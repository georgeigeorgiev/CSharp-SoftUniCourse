using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _05_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //On the first line, you will be given a username and your task is to try to log in the user. The user's password is the
            //username reversed. On the next lines, you will receive passwords:

            string username = Console.ReadLine();
            string password = Console.ReadLine();

            char[] stringArray = username.ToCharArray();
            Array.Reverse(stringArray);
            string truePassword = new string(stringArray);

            //• If the password is incorrect, print "Incorrect password. Try again.".
            //• If the password is correct, print "User {username} logged in." and stop the program.
            //Keep in mind that if the password is still incorrect on the fourth attempt, you should print: "User {username}
            //blocked!".

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
            //Then the program stops.

        }
    }
}