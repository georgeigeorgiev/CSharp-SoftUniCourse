using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System;
using System.Diagnostics.Contracts;
using System.Xml.Serialization;

namespace _07_VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double validCoin = 0.1;
            double validCoinA = 0.2;
            double validCoinB = 0.5;
            double validCoinC = 1;
            double validCoinD = 2;

            double nuts = 2.0;
            double water = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1.0;

            string nutsName = "nuts";
            string waterName = "water";
            string crispsName = "crisps";
            string sodaName = "soda";
            string cokeName = "coke";

            double coinsLeft = 0;

            while (true)
            {
                string choice = Console.ReadLine();

                bool isNumeric = double.TryParse(choice, out double coins);

                if (isNumeric)
                {
                    coins = double.Parse(choice);

                    if (coins == validCoin || coins == validCoinA || coins == validCoinB || coins == validCoinC || coins == validCoinD)
                    {
                        coinsLeft += coins;
                    }

                    else
                    {
                        Console.WriteLine($"Cannot accept {coins}");
                        continue;
                    }

                    
                }

                if (choice == "End" && !isNumeric)
                {
                    break;
                }

                if (choice == "Start" && !isNumeric)
                {
                    while (true)
                    {

                        choice = Console.ReadLine();

                        if (choice == "End" && !isNumeric)
                        {
                            goto LoopEnd;
                        }

                        if (choice != "Nuts" && choice != "Water" && choice != "Crisps" && choice != "Soda" && choice != "Coke" && !isNumeric)
                        {
                            Console.WriteLine($"Invalid product");
                            continue;
                        }

                        if (choice == "Nuts" && coinsLeft >= nuts)
                        {
                            Console.WriteLine($"Purchased {nutsName}");
                            coinsLeft -= nuts;
                        }

                        else if (choice == "Water" && coinsLeft >= water)
                        {
                            Console.WriteLine($"Purchased {waterName}");
                            coinsLeft -= water;
                        }

                        else if (choice == "Crisps" && coinsLeft >= crisps)
                        {
                            Console.WriteLine($"Purchased {crispsName}");
                            coinsLeft -= crisps;
                        }

                        else if (choice == "Soda" && coinsLeft >= soda)
                        {
                            Console.WriteLine($"Purchased {sodaName}");
                            coinsLeft -= soda;
                        }

                        else if (choice == "Coke" && coinsLeft >= coke)
                        {
                            Console.WriteLine($"Purchased {cokeName}");
                            coinsLeft -= coke;
                        }

                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }

                    }
                }


            }
            
            LoopEnd:
            Console.WriteLine($"Change: {coinsLeft:f2}");

        }
    }
}