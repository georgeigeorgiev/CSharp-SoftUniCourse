namespace _04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < input; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            int productNumber = 1;

            foreach (string product in products)
            {
                Console.WriteLine($"{productNumber}.{product}");
                productNumber++;
            }
        }
    }
}