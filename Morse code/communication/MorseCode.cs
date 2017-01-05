using MorseCode.protocol;
using MorseCode.text;

namespace MorseCode.communication
{
    public class MorseCode : StringConversor, IMorseCode
    {
        private bool _preserveWeirdChars = false;

        public MorseCode(IMorseType moreseType) : base(moreseType) { }

        public MorseCode(IMorseType moreseType, bool PreserveChars, string Separetor = "|") :
         this(moreseType)
        {
            _preserveWeirdChars = PreserveChars;
            _morseSepareator = Separetor;
        }

        public bool PreserveWeirdChars
        {
            get { return _preserveWeirdChars; }
        }

        public string WordSeparetor
        {
            get { return _morseSepareator; }
        }

        public string Morse(string text)
        {
            return ConvertToMorse(text);
        }

        public string UnMorse(string morse)
        {
            return ConvertFromMorse(morse);
        }
    }
}
