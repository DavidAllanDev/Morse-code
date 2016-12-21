using System.Collections.Generic;

namespace MorseCode.protocol
{
    public interface IMorseType
    {
        Dictionary<string, string> GetAlphabet();
        Dictionary<string, string> GetNumeral();
        Dictionary<string, string> GetProsigns();
    }
}