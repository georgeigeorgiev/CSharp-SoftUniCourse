using System.Buffers.Text;
using System.Diagnostics;
using System;

namespace _03_Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //• A count of people who are going on vacation.

            int people = int.Parse(Console.ReadLine());

            //• Type of the group(Students, Business or Regular).

            string typeOfGroup = Console.ReadLine();

            //• The day of the week which the group will stay on(Friday, Saturday or Sunday).

            string dayOfWeek = Console.ReadLine();
            
            //Based on the given information calculate how much the group will pay for the entire vacation.
            //The price for a single person is as follows:
            //Friday Saturday Sunday
            //Students 8.45 9.80 10.46
            //Business 10.90 15.60 16
            //Regular 15 20 22.50

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

            //There are also discounts based on some conditions:
            //• For Students – if the group is 30 or more people, you should reduce the total price by 15 %.
            //• For Business – if the group is 100 or more people, 10 of the people stay for free.
            //• For Regular – if the group is between 10 and 20 people(both inclusively), reduce the total price by 5 %.

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
            
            //Note: You should reduce the prices in that EXACT order!
            //As an output print the final price which the group is going to pay in the format:
            //"Total price: {price}"
            //The price should be formatted to the second decimal point.

            Console.WriteLine($"Total price: {fullPrice:f2}");
        }
    }
}