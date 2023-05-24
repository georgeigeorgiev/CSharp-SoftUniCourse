namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int waterTankCapacity = 255;

            int waterFill = 0;

            for (int i = 0; i < number; i++)
            {
                int fill = int.Parse(Console.ReadLine());

                waterFill += fill;

                if (waterFill > waterTankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    waterFill -= fill;
                    continue;
                }

            }

            Console.WriteLine(waterFill);


        }
    }
}