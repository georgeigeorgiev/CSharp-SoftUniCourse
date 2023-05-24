namespace _03_Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfPeople = int.Parse(Console.ReadLine());

            int coursesNumber = (int)Math.Ceiling((double)numberOfPeople / (double)capacityOfPeople);


            Console.WriteLine(coursesNumber);


        }
    }
}