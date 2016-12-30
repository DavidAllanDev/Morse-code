using System;
using System.Collections.Generic;

namespace MorseCode.protocol
{
    public class Prosign
    {
        public Dictionary<string, string> GetProsigns()
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                {"<AA>","·-·-"},
                {"<AR>","·-·-·"},
                {"<AS>","·-···"},
                {"<BT>","-···-"},
                {"<CT>","-·-·-"},
                {"<HH>","........"},
                {"<K>","-·-"},
                {"<KN>","-·--·"},
                {"<NJ>","-··---"},
                {"<SK>","···-·-"},
                {"<SN>","···-·"},
                {"<SOS>","···---···"},
                {"<BK>","-··· -·-"},
                {"<CL>","-·-· ·-··"},
            };
        }
    }
}
