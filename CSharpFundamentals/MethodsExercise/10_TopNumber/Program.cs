namespace _10_TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if (DivisableSum(i) == true && OddDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
                
                
            }


        }

        static bool DivisableSum(int a)
        {
            int[] result = Digits(a);
            int sum = 0;

            for (int i = 0; i < result.Length; i++)
            {
                sum += result[i];
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static bool OddDigit(int a)
        {
            int[] result = Digits(a);
            int counter = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] % 2 != 0)
                {
                    counter++;
                }
            }

            if (counter > 0)
            {
                return true; 
            }

            else
            {
                return false;
            }
        }

        static int[] Digits(int a)
        {
            string digit = a.ToString();
            int[] digits = new int[digit.Length];


            for (int i = digit.Length - 1; i >= 0; i--)
            {
                digits[i] = (int)digit[i] - '0';
            }

            return digits;
        }
    }
}