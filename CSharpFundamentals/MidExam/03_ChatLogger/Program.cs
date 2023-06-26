using System.Threading.Channels;

namespace _03_ChatLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
             List<string> chat = new List<string>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                Chat(chat, input);
                Delete(chat, input);
                Edit(chat, input);
                Pin(chat, input);
                Spam(input, chat);

                input = Console.ReadLine();
            }

            foreach (string line in chat)
            {
                Console.WriteLine(line);
            }
        }

        static void Chat(List<string> chat, string input)
        {
            string[] newString = input.Split();

            if (newString[0] == "Chat")
            {
                chat.Add(newString[1]);
            }
        }

        static void Delete(List<string> chat, string input)
        {
            string[] newString = input.Split();

            if (newString[0] == "Delete" && chat.Contains(newString[1]))
            {
                chat.Remove(newString[1]);
            }
        }

        static void Edit(List<string> chat, string input)
        {
            string[] newString = input.Split();

            if (newString[0] == "Edit" && chat.Contains(newString[1]))
            {
                int index = chat.FindIndex(s => s == newString[1]);

                if (index != -1)
                {
                    chat[index] = newString[2];
                }
            }
        }

        static void Pin(List<string> chat, string input)
        {
            string[] newString = input.Split();

            if (newString[0] == "Pin" && chat.Contains(newString[1]))
            {
                chat.Remove(newString[1]);
                chat.Add(newString[1]);

            }
        }

        static void Spam(string input, List<string> chat)
        {
            string[] newString = input.Split();

            if (newString[0] == "Spam")
            {
                for (int i = 1; i < newString.Length; i++)
                {
                    chat.Add(newString[i]);
                }
            }
        }


    }
}