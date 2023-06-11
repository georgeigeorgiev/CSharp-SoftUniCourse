namespace _01_DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int input = int.Parse(Console.ReadLine());

            if (input > 0 && input <= 7)
            {
                Console.WriteLine(days[input - 1]);
            }

            else
            {
                Console.WriteLine("Invalid day!");
            }
           

            
        }
    }
}