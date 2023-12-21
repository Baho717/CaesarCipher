using System;

namespace CaesarCipher
{
    public class Program
    {
        static void Main(string[] args)
        {
            mainMenu();
        }

        public static void mainMenu()
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            bool runApplication = true;

            while (runApplication)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Create a cipher");
                Console.WriteLine("2. Exit application");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Enter your message:");
                    string userMessage = Console.ReadLine();
                    string encryptedMessage = EncryptMessage(userMessage, alphabet);
                    Console.WriteLine("Encrypted Message:");
                    Console.WriteLine(encryptedMessage);
                }
                else if (option == "2")
                {
                    Console.WriteLine("Exiting application.");
                    runApplication = false;
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                }
            }
        }

        public static string EncryptMessage(string userMessage, char[] alphabet)
        {
            char[] secretMessage = userMessage.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char currentChar = secretMessage[i];
                bool isUpper = char.IsUpper(currentChar);
                currentChar = char.ToLower(currentChar);
                int index = Array.IndexOf(alphabet, currentChar);

                if (index != -1)
                {
                    int newLetters = (index + 3) % alphabet.Length;
                    encryptedMessage[i] = isUpper ? char.ToUpper(alphabet[newLetters]) : alphabet[newLetters];
                }
                else
                {
                    encryptedMessage[i] = secretMessage[i];
                }
            }

            return new string(encryptedMessage);
        }
    }
}
