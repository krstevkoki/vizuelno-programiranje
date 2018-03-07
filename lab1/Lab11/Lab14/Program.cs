using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string myString = "This is a test.";
            char[] separator = {' '};
            string[] myWords = myString.Split(separator);
            foreach (string word in myWords)
                Console.WriteLine("{0}", word);

            Console.ReadKey();
        }
    }
}