namespace GhTrainingLib;

public static class AssiiHelper
{
    public static int GetAsciiValue(char character)
    {
        if (!char.IsLetterOrDigit(character))
        {
            throw new ArgumentException("Character must be a letter or digit.");
        }
        return (int)character;
    }
}
