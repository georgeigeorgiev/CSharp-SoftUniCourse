namespace _03_CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstInput = char.Parse(Console.ReadLine());

            char secondInput = char.Parse(Console.ReadLine());

            if ((int)secondInput < (int)firstInput)
            {
                CharacterInRange(secondInput, firstInput);
            }

            else
            {
                CharacterInRange(firstInput, secondInput);
            }
        }

        static void CharacterInRange(char firstInput, char secondInput)
        {
            for (int i = (int)firstInput + 1; i < (int)secondInput; i++)
            {
                Console.Write((char)i + " ");

            }


        }
    }
}