namespace MorseCode.communication
{
    public interface IMorseCode
    {
        string WordSeparetor { get; }
        bool PreservePreserveWeirdChars { get; }

        string Morse(string text);
        string UnMorse(string morse);
    }
}