namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double energyLeft = energy;
            
            int waterDay = 1;
            int foodDay = 1;

            double waterAll = water * players * days;
            double foodAll = food * players * days;

            for (int i = 1; i <= days; i++)
            {
                double energyExpense = double.Parse(Console.ReadLine());

                energyLeft = energyLeft - energyExpense;

                if (energyLeft <= 0)
                {
                    break;
                }

                if (waterDay >= 2)
                {
                    energyLeft += energyLeft * 0.05;
                    waterAll = waterAll * 0.70;
                    waterDay = 0;
                }

                if (foodDay >= 3)
                {
                    foodAll -= foodAll / players;
                    energyLeft += energyLeft * 0.10;
                    foodDay = 0;
                }

                waterDay++;
                foodDay++;

                

            }

            if (energyLeft > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energyLeft:f2} energy!");
            }

            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {foodAll:f2} food and {waterAll:f2} water.");
            }
        }

        
    }
}