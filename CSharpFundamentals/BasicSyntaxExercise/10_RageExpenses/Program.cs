namespace _10_RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine()); 
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCounter = 0;
            int mouseCounter = 0;
            int keyboardCounter = 0;
            int displayCounter = 0;
            double totalExpenses = 0;

            for (int i = 2; i <= lostGames;  i+= 2)
            {
                headsetCounter++;
            }

            for (int j = 3; j <= lostGames; j += 3)
            {
                mouseCounter++;

                if (j % 2 == 0)
                {
                    keyboardCounter++;

                }
            }

            for (int k = 2; k <= keyboardCounter;  k += 2)
            {
                displayCounter++;
            }


            totalExpenses = (headsetPrice * headsetCounter) + (mousePrice * mouseCounter) + (keyboardPrice * keyboardCounter) + (displayPrice * displayCounter);

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}