using System;
using System.Linq;
using MorseCode.protocol;

namespace MorseCode.text
{
    public class StringConversor : IStringConversor
    {
        private IMorseType _morseType;
        protected string _morseSepareator;

        public StringConversor(IMorseType moreseType)
        {
            _morseType = moreseType;
        }

        public string ConvertToMorse(string message)
        {
            if (hasProsigns(message))
                message = GetProsignMoser(message);
            var charList = message.ToCharArray();
            return ConvertCharsToMorse(charList);
        }

        private string GetProsignMoser(string message)
        {
            foreach(var item in _morseType.GetProsigns())
            {
                message.Replace(item.Key, item.Value);
            }
            return message;
        }

        private string ConvertCharsToMorse(char[] values)
        {
            string result = "";
            foreach (char item in values)
            {
                result = result + GetAMorseFor(item.ToString(), _morseType)+ _morseSepareator;
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
            else
                return item;
        }

        public string ConvertFromMorse(string morse)
        {
            var list = morse.Split(Convert.ToChar(_morseSepareator)).Select(n => (n)).ToArray();
            return ConvertStringFromMorse(list);
        }

        private string ConvertStringFromMorse(string[] list)
        {
            string result = "";
            foreach (string item in list)
            {
                result = result + GetFromMorse(item.ToString(), _morseType);
            }
            return result;
        }

        private string GetFromMorse(string element, IMorseType morser)
        {
            if (morser.GetAlphabet().ContainsValue(element))
            {
                return morser.GetAlphabet().FirstOrDefault(x => x.Value == element).Key;
            }
            else if (morser.GetNumeral().ContainsValue(element))
            {
                return morser.GetNumeral().FirstOrDefault(x => x.Value == element).Key;
            }
            else
                return element;
        }

        public bool hasProsigns(string text)
        {
            return _morseType.GetProsigns().ContainsKey(text);
        }
    }
}
