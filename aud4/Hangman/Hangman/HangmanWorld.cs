using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class HangmanWorld
    {
        private const int MINUTES = 10;
        public static readonly int MAX_TIME = 60 * MINUTES; // working with seconds is much easier
        public static readonly int MAX_WRONG = 10;
        private readonly char FIRST_LETTER;
        public int RemovingOccurencesNumber { get; private set; }
        public string Word { get; }
        public HashSet<char> AllLetters { get; }
        public List<char> WordLetters { get; }
        public ArrayWordSelector WordSelector { get; }

        public HangmanWorld()
        {
            WordSelector = new ArrayWordSelector();
            Word = WordSelector.pick().ToLower();
            FIRST_LETTER = Word[0];
            AllLetters = new HashSet<char>();
            WordLetters = new List<char>();

            foreach (char c in Word)
                WordLetters.Add(c);
        }

        public string GetMaskedWord()
        {
            StringBuilder sb = new StringBuilder();
            bool firstOccurence = true;
            foreach (char c in Word)
            {
                if (WordLetters.Contains(c))
                    sb.Append("_");
                else
                {
                    if (c == FIRST_LETTER && firstOccurence)
                    {
                        sb.Append(char.ToUpper(c));
                        firstOccurence = false;
                    }
                    else
                        sb.Append(c);
                }

                sb.Append(" ");
            }

            return sb.ToString();
        }

        public string GetAllLetters()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 'a'; i <= 'z'; ++i)
            {
                if (AllLetters.Contains((char) i))
                    sb.Append((char) i);
                else
                    sb.Append("_");
                if (i != 'z')
                    sb.Append(" ");
            }

            return sb.ToString();
        }

        public bool ValidateGuessedChar(char guess)
        {
            if (!AllLetters.Add(guess)) // if already tried that letter
                return false;
            RemovingOccurencesNumber = WordLetters.RemoveAll(c => c == guess);
            return true;
        }

        public bool DidWin()
        {
            return WordLetters.Count == 0;
        }
    }
}