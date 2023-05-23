using System.Buffers.Text;
using System.Diagnostics;
using System;

namespace _03_Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            string typeOfGroup = Console.ReadLine();

            string dayOfWeek = Console.ReadLine();
            
            double studentFridayPrice = 8.45;
            double studentSaturdayPrice = 9.80;
            double studentSundayPrice = 10.46;

            double businessFridayPrice = 10.90;
            double businessSaturdayPrice = 15.60;
            double businessSundayPrice = 16.00;

            double regularFridayPrice = 15.00;
            double regularSaturdayPrice = 20.00;
            double regularSundayPrice = 22.50;

            double fullPrice = 0;

            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    fullPrice = people * studentFridayPrice;
                }

                else if (dayOfWeek == "Saturday")
                {
                    fullPrice = people * studentSaturdayPrice;
                }

                else if (dayOfWeek == "Sunday")
                {
                    fullPrice = people * studentSundayPrice;
                }

            }

            else if (typeOfGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    fullPrice = people * businessFridayPrice;
                }

                else if (dayOfWeek == "Saturday")
                {
                    fullPrice = people * businessSaturdayPrice;
                }

                else if (dayOfWeek == "Sunday")
                {
                    fullPrice = people * businessSundayPrice;
                }
            }

            else if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    fullPrice = people * regularFridayPrice;
                }

                else if (dayOfWeek == "Saturday")
                {
                    fullPrice = people * regularSaturdayPrice;
                }

                else if (dayOfWeek == "Sunday")
                {
                    fullPrice = people * regularSundayPrice;
                }
            }

            if (typeOfGroup == "Students" && people >= 30)
            {
                fullPrice = fullPrice * 0.85;
            }
            
            if (typeOfGroup == "Business" && people >= 100)
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        fullPrice = fullPrice - (businessFridayPrice * 10);
                        break;
                    case "Saturday":
                        fullPrice = fullPrice - (businessSaturdayPrice * 10);
                        break;
                    case "Sunday":
                        fullPrice = fullPrice - (businessSundayPrice * 10);
                        break;
                }

            }

            if (typeOfGroup == "Regular" && people >= 10 && people <= 20)
            {
                fullPrice = fullPrice * 0.95;
            }
            
            Console.WriteLine($"Total price: {fullPrice:f2}");
        }
    }
}