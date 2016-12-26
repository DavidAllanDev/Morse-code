using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorseCode.protocol;
using MorseCode.text;

namespace MorseCode.communication
{
    public class MorseCode : StringConversor, IMorseCode
    {
        private bool _preservePreserveWeirdChars = false;
        private string _wordSeparetor = "";

        public MorseCode(IMorseType moreseType) : base(moreseType) { }

        public MorseCode(IMorseType moreseType, bool PreserveChars, string Separetor = "|") :
         this(moreseType)
        {
            _preservePreserveWeirdChars = PreserveChars;
            _wordSeparetor = Separetor;
        }

        public bool PreservePreserveWeirdChars
        {
            get { return _preservePreserveWeirdChars; }
        }

        public string WordSeparetor
        {
            get { return _wordSeparetor; }
        }

        public string Morse(string text)
        {
            return ConvertToMorse(text);
        }

        public string UnMorse(string morse)
        {
            throw new NotImplementedException();
        }
    }
}
