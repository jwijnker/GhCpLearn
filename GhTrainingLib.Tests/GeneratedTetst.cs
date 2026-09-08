namespace GhTrainingLib.Tests;

public class GeneratedTetst
{
    [Theory]
    [InlineData('A', 65)]
    [InlineData('z', 122)]
    [InlineData('7', 55)]
    public void GetAsciiValue_ReturnsAsciiCode_ForLettersAndDigits(char input, int expected)
    {
        Assert.Equal(expected, AssiiHelper.GetAsciiValue(input));
    }

    [Theory]
    [InlineData(' ')]
    [InlineData('-')]
    [InlineData('_')]
    [InlineData('.')]
    public void GetAsciiValue_ThrowsArgumentException_ForNonAlphanumeric(char input)
    {
        Assert.Throws<ArgumentException>(() => AssiiHelper.GetAsciiValue(input));
        // TODO: Add more test cases for edge cases and additional characters if needed 

    }
}