namespace _05_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            OrderCalculation(product, quantity);

        }

        static void OrderCalculation(string product, int quantity)
        {
            double[] pricesArray = { 1.50, 1.00, 1.40, 2.00 };
            double totalPrice = 0;

            switch (product)
            {
                case "coffee":
                    totalPrice = pricesArray[0] * quantity;
                    break;
                case "water":
                    totalPrice = pricesArray[1] * quantity;
                    break;
                case "coke": 
                    totalPrice = pricesArray[2] * quantity;
                    break;
                case "snacks":
                    totalPrice = pricesArray[3] * quantity;
                    break;

            }

            Console.WriteLine($"{totalPrice:f2}");
        }


    }
}