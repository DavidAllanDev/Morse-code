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
            var charList = message.ToCharArray();
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
                return item;
        }
    }
}
