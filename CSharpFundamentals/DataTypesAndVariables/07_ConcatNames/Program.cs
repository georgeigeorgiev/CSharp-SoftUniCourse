using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace _07_ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            string finalString = String.Concat(firstName, delimiter, lastName);

            Console.WriteLine(finalString);

        }
    }
}