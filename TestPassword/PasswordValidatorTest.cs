using FluentAssertions;

namespace TestPassword;

public class PasswordValidatorTest
{
    [Fact]
    public void IsValidShouldReturnFalse_WhenGivenAPasswordShorterThan8Characters() {
        // Arrange
        string password = "aA1!123";
        // Act
        bool result = PasswordValidator.IsValid(password);
        // Assert
        result.Should().BeFalse();
    }
    
    [Fact]
    public void IsValidShouldReturnFalse_WhenGivenAPasswordLongerThan50Characters() {
        // Arrange
        string password = "aA1!12345678901234567890123456789012345678901234567";
        // Act
        bool result = PasswordValidator.IsValid(password);
        // Assert
        result.Should().BeFalse();
    }
    
    [Fact]
    public void IsValidShouldReturnFalse_WhenGivenAPasswordWithoutLowerCaseLetters() {
        // Arrange
        string password = "AA1!1234";
        // Act
        bool result = PasswordValidator.IsValid(password);
        // Assert
        result.Should().BeFalse();
    }
    
    [Fact]
    public void IsValidShouldReturnFalse_WhenGivenAPasswordWithoutUpperCaseLetters() {
        // Arrange
        string password = "aa1!1234";
        // Act
        bool result = PasswordValidator.IsValid(password);
        // Assert
        result.Should().BeFalse();
    }
    
    [Fact]
    public void IsValidShouldReturnFalse_WhenGivenAPasswordWithoutValidSymbols() {
        // Arrange
        string password = "aA112345";
        // Act
        bool result = PasswordValidator.IsValid(password);
        // Assert
        result.Should().BeFalse();
    }
    
    [Fact]
    public void IsValidShouldReturnFalse_WhenGivenAPasswordWithInvalidSymbols() {
        // Arrange
        string password = "aA1!?123";
        // Act
        bool result = PasswordValidator.IsValid(password);
        // Assert
        result.Should().BeFalse();
    }
    
    [Fact]
    public void IsValidShouldReturnFalse_WhenGivenAPasswordWithNonAsciiChars() {
        // Arrange
        string password = "aA1!🙂123";
        // Act
        bool result = PasswordValidator.IsValid(password);
        // Assert
        result.Should().BeFalse();
    }
    
    [Fact]
    public void IsValidShouldReturnTrue_WhenGivenAValidPassword() {
        // Arrange
        string password = "aA1!1234";
        // Act
        bool result = PasswordValidator.IsValid(password);
        // Assert
        result.Should().BeTrue();
    }
    
}
