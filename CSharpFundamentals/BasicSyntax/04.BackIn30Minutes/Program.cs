namespace _04.BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hourInMinutes = hour * 60;

            int addedTime = hourInMinutes + minutes + 30;

            int finalHour = addedTime / 60;
            int finalMinutes = addedTime % 60;

            if (finalHour == 24)
            {
                finalHour = 0;
                
            }

             if (finalMinutes < 10)
            {
                Console.WriteLine($"{finalHour}:{finalMinutes:d2}");
            }

             else
            {
                Console.WriteLine($"{finalHour}:{finalMinutes}");
            }

            
        }
    }
}