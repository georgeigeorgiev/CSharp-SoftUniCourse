namespace _08_MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            double powNumber = double.Parse(Console.ReadLine());

            double result = MathPowerOfABaseNumber(baseNumber, powNumber);

            Console.WriteLine(result);
        }

        static double MathPowerOfABaseNumber(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}