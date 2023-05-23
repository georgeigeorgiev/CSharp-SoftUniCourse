using System.ComponentModel;
using System;
using System.Globalization;

namespace _06_StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that receives a single integer and calculates if it's strong or not. A number is strong, if the sum of
            //the factorials of each digit is equal to the number itself.
            //Example: 145 is a strong number, because 1! + 4! + 5! = 145.
            //Print "yes", if the number is strong and "no", if the number is not strong.

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