using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class Program
    {
        private static void Min(int[] numbers, out int minNumber)
        {
            minNumber = Int32.MaxValue;
            foreach (var number in numbers)
                if (minNumber > number)
                    minNumber = number;
        }

        private static void Max(int[] numbers, out int maxNumber)
        {
            maxNumber = Int32.MinValue;
            foreach (var number in numbers)
                if (maxNumber < number)
                    maxNumber = number;
        }

        private static decimal average(int sum, int n)
        {
            return Convert.ToDecimal(sum) / n;
        }

        public static void Main(string[] args)
        {
            Console.Write("Vnesete vkupen broj na broevi: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            int sum = 0;

            Console.Write("Dali sakate da se generiraat random broevi? (Y/n): ");
            bool generateRandom = Console.ReadLine().ToUpper() == "Y";

            Random random = new Random();
            for (int i = 0; i < n; ++i)
            {
                int num;
                if (generateRandom)
                {
                    num = random.Next(1, 1001);
                    Console.WriteLine("Broj {0}: {1}", i + 1, num);
                }
                else
                {
                    Console.Write("Broj {0}: ", i + 1);
                    num = int.Parse(Console.ReadLine());
                }

                numbers[i] = num;
                sum += num;
            }

            Min(numbers, out int minNumber);
            Max(numbers, out int maxNumber);
            Console.WriteLine("Average: {0:0.00}, Min number: {1}, Max number: {2}",
                average(sum, n), minNumber, maxNumber);
            Console.Read();
        }
    }
}