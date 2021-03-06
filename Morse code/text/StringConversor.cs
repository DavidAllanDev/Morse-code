﻿using System;
using System.Linq;
using MorseCode.protocol;

namespace MorseCode.text
{
    public class StringConversor : IStringConversor
    {
        private IMorseType _morseType;
        protected string _morseSepareator = "|";

        public StringConversor(IMorseType moreseType)
        {
            _morseType = moreseType;
        }

        public string ConvertToMorse(string message)
        {
            if (HasTextProsigns(message))
            {
                return ConvertToMorseWithProsigns(message);
            }

            return ConvertStringToMorse(message);
        }

        private string ConvertToMorseWithProsigns(string message)
        {
            message = GetProsignMoser(message);
            var messageList = message.Split(Convert.ToChar(_morseSepareator)).ToArray();

            string morseMessage = "";

            foreach (string line in messageList)
            {
                if (HasMorseProsigns(line))
                    morseMessage = morseMessage + line + _morseSepareator;
                else
                    morseMessage = morseMessage + ConvertStringToMorse(line);
            }
            return morseMessage;
        }

        private string ConvertStringToMorse(string line)
        {
            var charList = line.ToCharArray();
            return ConvertCharsToMorse(charList);
        }

        private string GetProsignMoser(string message)
        {
            foreach(var item in _morseType.GetProsigns())
            {
                message = message.Replace(item.Key, item.Value + _morseSepareator);
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
            if (HasMorseProsigns(morse))
                morse = GetProsignKey(morse);

            var list = morse.Split(Convert.ToChar(_morseSepareator)).Select(n => (n)).ToArray();
            return ConvertStringFromMorse(list);
        }

        private string GetProsignKey(string morse)
        {
            foreach (var item in _morseType.GetProsigns())
            {
                morse = morse.Replace(item.Value, item.Key);
            }
            return morse;
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

        public bool HasTextProsigns(string text)
        {
            var wordList = text.Split(Convert.ToChar(" ")).ToArray();

            foreach (var word in wordList)
            {
                if(_morseType.GetProsigns().ContainsKey(word))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasMorseProsigns(string text)
        {
            var letterList = text.Split(Convert.ToChar(_morseSepareator)).ToArray();

            foreach (var letter in letterList)
            {
                if (_morseType.GetProsigns().ContainsValue(letter))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
