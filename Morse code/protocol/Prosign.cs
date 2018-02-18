using System;
using System.Collections.Generic;

namespace MorseCode.protocol
{
    public class Prosign //https://en.wikipedia.org/wiki/Prosigns_for_Morse_code
    {
        public Dictionary<string, string> GetProsigns()
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
            {"<AA>","·-·-"}, // UNKNOWN STATION
            {"<AR>","·-·-·"}, // OUT
            {"<AS>","·-···"}, // WAIT
            {"<BT>","-···-"}, // BREAK
            {"<CT>","-·-·-"}, // Start of transmission[4] Start of new message.[1]
            {"<HH>","........"}, // Error / correction[4][1]
            {"<K>","-·-"}, // Invitation for any station to transmit[4][1]
            { "<KN>","-·--·"}, // Invitation for named station to transmit[1]
            { "<NJ>","-··---"}, // Shift to Wabun code(https://en.wikipedia.org/wiki/Wabun_code)
            { "<SK>","···-·-"}, // End of contact[1] / End of work[4]
            { "<SN>","···-·"}, // Understood.[1] Verified.[4]
            { "<SOS>","···---···"}, // Start of distress signal[4][1]
            { "<BK>","-··· -·-"}, // Break in conversation[1]
            { "<CL>","-·-· ·-··"}, // Closing down[1]
            };
        }
    }
}
