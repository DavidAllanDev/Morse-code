using System.Collections.Generic;

namespace Morse_code.protocol
{
    public interface IMorseType
    {
        Dictionary<string, string> GetAlphabet();
        Dictionary<string, string> GetNumeral();
    }
}