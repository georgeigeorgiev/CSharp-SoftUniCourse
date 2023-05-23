using System.ComponentModel;
using System;
using System.Globalization;

namespace _06_StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string numberToString = number.ToString();
            int a = 0;
            int b = 1;
            int finalNumber = 0;
            char individualNumbers = numberToString[a];
            int numbersInd = (int)(individualNumbers - '0');

            while (a < numberToString.Length)
            {
                individualNumbers = numberToString[a];
                numbersInd = (int)(individualNumbers - '0');

                for (int i = 1; i <= numbersInd; i++)
                {
                    b = b * i;
                    
                }
                a++;

                finalNumber += b;
                b = 1;

            }

            if (finalNumber == number)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }


        }
    }
}