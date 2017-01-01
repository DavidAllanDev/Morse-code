namespace MorseCode.communication
{
    public interface IMorseCode
    {
        string WordSeparetor { get; }
        bool PreserveWeirdChars { get; }

        string Morse(string text);
        string UnMorse(string morse);
    }
}