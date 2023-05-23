using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Xml.Schema;

namespace _11_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            int counter = 1;

            while (true)
            {
                if (counter > countOfOrders)
                {
                    break;
                }

                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double orderPrice = 0;
                

                for (int i = counter; i <= countOfOrders; i++)
                {

                    orderPrice = (days * capsulesCount) * pricePerCapsule;

                    totalPrice += orderPrice;

                    Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");

                    break;

                }

                counter++;

            }

            Final:
            Console.WriteLine($"Total: ${totalPrice:F2}");



        }
    }
}