using System.Numerics;

namespace _11_Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            BigInteger maxValue = 0;
            int snow = 0;
            int time = 0;
            int quality = 0;

            for (int i = 0; i < snowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                    if (snowballValue > maxValue)
                {
                    snow = snowballSnow;
                    quality = snowballQuality;
                    time = snowballTime;
                    maxValue = snowballValue;
                }

                snowballValue = 0;


            }

            Console.WriteLine($"{snow} : {time} = {maxValue} ({quality})");
        }
    }
}