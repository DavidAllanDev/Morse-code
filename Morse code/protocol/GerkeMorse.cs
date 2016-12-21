using System;
using System.Collections.Generic;

namespace MorseCode.protocol
{
    public class GerkeMorse : Prosign,IMorseType
    {
        public Dictionary<string, string> GetAlphabet()
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                {"A","· —"},
                {"B","— · · ·"},
                {"C","· ·  ·"},
                {"D","— · ·"},
                {"E","·"},
                {"F","· — ·"},
                {"G","— — ·"},
                {"H","· · · ·"},
                {"I","· ·"},
                {"J","— · — ·"},
                {"K","— · —"},
                {"L","——"},
                {"M","— —"},
                {"N","— ·"},
                {"O","· ·"},
                {"P","· · · · ·"},
                {"Q","· · —  ·"},
                {"R","·  · ·"},
                {"S","· · ·"},
                {"T","—"},
                {"U","· · —"},
                {"V","· · · —"},
                {"W","· — —"},
                {"X","· — · ·"},
                {"Y","· ·  · ·"},
                {"Z","· · ·  ·"},
            };
        }

        public Dictionary<string, string> GetNumeral()
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                {"1","· — — ·"},
                {"2","· · — · ·"},
                {"3","· · · — ·"},
                {"4","· · · · —"},
                {"5","— — —"},
                {"6","· · · · · ·"},
                {"7","— — · ·"},
                {"8","— · · · ·"},
                {"9","— · · —"},
                {"0","————"},
            };
        }

        public Dictionary<string, string> GetProsigns()
        {
            return base.GetProsigns();
        }
    }
}
