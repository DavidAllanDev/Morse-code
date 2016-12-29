namespace MorseCode.text
{
    public interface IStringConversor
    {
        string ConvertToMorse(string message);
        string ConvertFromMorse(string morse);
    }
}