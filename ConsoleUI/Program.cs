using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            do
            {

                Console.Clear();
                char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                //user input
                Console.Write("Please, enter top secret message: ");
                string secret = Console.ReadLine();
                //convert to char
                char[] secretMessage = secret.ToCharArray();
                //new var for encrypted msg
                char[] encryptedMsg = new char[secret.Length];
                //variables for conversion

                int alphaIndex = 0;
                //incrypt using loop
                for (int i = 0; i < secretMessage.Length; i++)
                {
                    char t = secretMessage[i];
                    alphaIndex = Array.IndexOf(alphabet, t);
                    alphaIndex = (alphaIndex + 3) % alphabet.Length;

                    encryptedMsg[i] = alphabet[alphaIndex];
                }

                string result = String.Join("", encryptedMsg);
                Console.WriteLine(result);

                Console.WriteLine("Do you wanna play again? (yes/no)");

                answer = Console.ReadLine();
            } while (answer == "yes");
        }
    }
}
