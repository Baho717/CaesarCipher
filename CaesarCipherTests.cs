using Xunit;
using CaesarCipher;

public class CaesarCipherTests
{
    private static readonly char[] Alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

    [Fact]
    public void EncryptMessage_WithLowerCaseString_ReturnsEncryptedString()
    {
        // Arrange
        var input = "abc";
        var expected = "def"; 
        // Act
        var result = Program.EncryptMessage(input, Alphabet);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void EncryptMessage_WithUpperCaseString_ReturnsEncryptedString()
    {
        // Arrange
        var input = "ABC";
        var expected = "DEF";

        // Act
        var result = Program.EncryptMessage(input, Alphabet);

        // Assert
        Assert.Equal(expected, result);
    }
}
