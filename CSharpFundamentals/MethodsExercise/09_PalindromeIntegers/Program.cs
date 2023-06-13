namespace _09_PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberInput = Console.ReadLine();

            
            while (EndCommand(numberInput) != true)
            {
                if (PositiveInteger(numberInput) == false)
                {
                    return;
                }

                if (PalindromeIntegers(numberInput) == true)
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine("false");
                }

                numberInput = Console.ReadLine();
            }
            
        }

        static bool PalindromeIntegers(string numberInput)
        {
            char[] newArray = numberInput.ToCharArray();
            Array.Reverse(newArray);
            string reversedNumber = new string(newArray);

            if (numberInput == reversedNumber)
            {
                return true;
            }
            
            else
            {
                return false;
            }
        }

        static bool PositiveInteger(string numberInput)
        {
            if (int.Parse(numberInput) >= 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static bool EndCommand(string numberInput)
        {
            if (numberInput != "END")
            {
                return false;
            }
            
            else
            {
                return true;
            }
        }
    }
}