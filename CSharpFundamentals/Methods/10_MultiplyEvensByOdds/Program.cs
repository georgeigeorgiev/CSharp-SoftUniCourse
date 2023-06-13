namespace _10_MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int inputNumber = Math.Abs(number);

            Console.WriteLine(MultiplyEvenByOdds(inputNumber));
        }

        static int MultiplyEvenByOdds(int a)
        {
            int evens = GetSumOfEvens(a);
            int odds = GetSumOfOdds(a);

            return evens * odds;
        }

        static int GetSumOfEvens(int a)
        {
            string holder = a.ToString();
            int holderInt = int.Parse(holder); 

            int[] arrayEvens = new int[holder.Length];

            for (int i = 0; i < arrayEvens.Length; i++)
            {
                arrayEvens[i] = holder[i] - '0';
            }

            int evenSum = 0;

            for (int i = 0; i < arrayEvens.Length; i++)
            {
                if (arrayEvens[i] % 2 == 0)
                {
                    evenSum += arrayEvens[i];
                }
            }

            return evenSum;
        }

        static int GetSumOfOdds(int a)
        {
            string holder = a.ToString();

            int[] arrayOdds = new int[holder.Length];

            for (int i = 0; i < arrayOdds.Length; i++)
            {
                arrayOdds[i] = holder[i] - '0';
            }

            int oddSum = 0;

            for (int i = 0; i < arrayOdds.Length; i++)
            {
                if (arrayOdds[i] % 2 != 0)
                {
                    oddSum += arrayOdds[i];
                }
            }

            return oddSum;
        }
    }
}