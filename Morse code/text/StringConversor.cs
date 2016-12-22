using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorseCode.protocol;

namespace MorseCode.text
{
    public class StringConversor
    {
        private IMorseType _morseType;
        public StringConversor(IMorseType moreseType)
        {
            _morseType = moreseType;
        }

        public string ConvertToMorse(string message)
        {
            return ToMorseCode(message);
        }

        public string ToMorseCode(string text)
        {
            var charList = text.ToCharArray();
            return ConvertCharsToMorse(charList);
        }

        private string ConvertCharsToMorse(char[] values)
        {
            string result = "";
            foreach (char item in values)
            {
                result = result + GetAMorseFor(item.ToString(), _morseType);
            }

            return result;
        }

        private string GetAMorseFor(string item, IMorseType morser)
        {
            if (morser.GetAlphabet().ContainsKey(item))
            {
                return morser.GetAlphabet()[item];
            }
            else if (morser.GetNumeral().ContainsKey(item))
            {
                return morser.GetNumeral()[item];
            }
            else if (morser.GetProsigns().ContainsKey(item))
            {
                return morser.GetProsigns()[item];
            }
            else
                return "";
        }
    }
}
