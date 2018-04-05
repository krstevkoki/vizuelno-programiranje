using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class ArrayWordSelector
    {
        private Random random;

        private static readonly string[] Words = new string[]
        {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andora",
            "Angola ",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Croatia ",
            "Cuba    ",
            "Cyprus  ",
            "Denmark ",
            "Djibouti",
            "Dominica",
            "Ecuador ",
            "Egypt   ",
            "Eritrea ",
            "Estonia ",
            "Ethiopia",
            "Fiji    ",
            "Finland ",
            "France  ",
            "Gabon   ",
            "Gambia  ",
            "Georgia ",
            "Germany ",
            "Ghana   ",
            "Greece  ",
            "Grenada ",
            "Guatemala",
            "Guinea  ",
            "Guyana  ",
            "Haiti   ",
            "Honduras",
            "Hungary ",
            "Iceland ",
            "India   ",
            "Indonesia",
            "Iran    ",
            "Iraq    ",
            "Israel  ",
            "Italy   ",
            "Jamaica ",
            "Japan   ",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Macedonia",
            "Malta"
        };

        public ArrayWordSelector()
        {
            random = new Random();
        }

        public string pick()
        {
            int index = random.Next(Words.Length);
            return Words[index].Trim();
        }
    }
}