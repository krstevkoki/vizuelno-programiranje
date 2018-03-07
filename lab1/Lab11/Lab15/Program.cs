using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    enum PasswordStrength
    {
        Easy,
        Normal,
        Hard
    }

    public class Program
    {
        private static String GenerateRandomPassword(PasswordStrength passwordStrength)
        {
            StringBuilder sb = new StringBuilder();
            Random smallLettersGenerator = new Random();
            Random capitalLettersGenerator = new Random();
            Random specialCharsGenerator = new Random();
            Random choiceGenerator = new Random();
            Random passwordLength = new Random();

            if (passwordStrength == PasswordStrength.Easy)
            {
                int length = passwordLength.Next(1, 7); // 1-6
                for (int i = 1; i <= length; ++i)
                    sb.Append((char) smallLettersGenerator.Next(97, 123)); // 97-122
            }

            else if (passwordStrength == PasswordStrength.Normal)
            {
                int length = passwordLength.Next(6, 10);
                Random numbersGenerator = new Random();
                for (int i = 1; i <= length; ++i)
                {
                    int choice = choiceGenerator.Next(0, 2); // 0-1
                    if (choice == 0)
                        sb.Append((char) capitalLettersGenerator.Next(65, 91)); // 65-90
                    if (choice == 1)
                        sb.Append((char) numbersGenerator.Next(48, 58)); // 48-57
                }
            }

            else if (passwordStrength == PasswordStrength.Hard)
            {
                int length = passwordLength.Next(10, 31); // 10-30
                Random numbersGenerator = new Random();
                for (int i = 1; i <= length; ++i)
                {
                    int choice = choiceGenerator.Next(0, 3); // 0-2
                    if (choice == 0)
                        sb.Append((char) capitalLettersGenerator.Next(65, 91)); // 65-90
                    if (choice == 1)
                        sb.Append((char) specialCharsGenerator.Next(33, 48)); // 33-47
                    if (choice == 2)
                        sb.Append((char) smallLettersGenerator.Next(97, 123)); // 97-122
                }
            }

            return sb.ToString();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter passwords in one line separated by blank space:");
            string[] lineParts = Console.ReadLine().Split(' ');
            string weakPassword = GenerateRandomPassword(PasswordStrength.Easy);
            string normalPassword = GenerateRandomPassword(PasswordStrength.Normal);
            string strongPassword = GenerateRandomPassword(PasswordStrength.Hard);

            foreach (string password in lineParts)
            {
                if (password == weakPassword)
                    Console.WriteLine("You've guessed the weak password");
                else if (password == normalPassword)
                    Console.WriteLine("You've guessed the normal password");
                else if (password == strongPassword)
                    Console.WriteLine("You've guessed the strong password");
                else
                    Console.WriteLine("Try again");
            }

            Console.Read();
        }
    }
}