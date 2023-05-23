using System.Diagnostics.Metrics;

namespace _09_PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double moneyAvailable = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            int beltCount = 0;

            double lightsaberAmount = Math.Ceiling(students + students * 0.1);

            for (int i = 6; i <= students; i += 6)
            {
                beltCount++;
            }

            int beltsStudents = students - beltCount;

            totalPrice = (lightsaberAmount * lightsaberPrice) + (students * robesPrice) + (beltsStudents * beltsPrice);

            if (totalPrice <= moneyAvailable)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }

            else if (totalPrice > moneyAvailable)
            {
                Console.WriteLine($"John will need {(totalPrice - moneyAvailable):f2}lv more.");
            }

        }
    }
}