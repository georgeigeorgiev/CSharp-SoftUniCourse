using System.ComponentModel.Design;

namespace _04_PasswordValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine().ToLower();

            
            if (PasswordLength(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (ContainingLettersOrDigits(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (ContainingTwoDigits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (PasswordLength(password) == true && ContainingLettersOrDigits(password) == true && ContainingTwoDigits(password) == true)
            {
                Console.WriteLine("Password is valid");
            }

           
        }

        static bool PasswordLength(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        static bool ContainingLettersOrDigits(string password)
        {
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if ((int)password[i] < 97 && (int)password[i] > 57 || (int)password[i] > 122 || (int)password[i] < 48)
                {
                    counter++;
                }

            }

            if (counter >= 1)
            {
                return false;
            }

            else
            {
                return true;
            }
            
        }

        static bool ContainingTwoDigits(string password)
        {
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if ((int)password[i] <= 57 && (int)password[i] >= 48)
                {
                    counter++;
                }

            }

            if (counter < 2)
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