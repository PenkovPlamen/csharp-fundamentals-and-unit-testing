using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new() { "racecar", "level", "hannah" };
        bool expected = true;
        // Act
        bool result = Palindrome.IsPalindrome(words);
        // Assert
        Assert.IsTrue(result);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();
        bool expected = true;

        // Act
        bool result = Palindrome.IsPalindrome(words);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> words = new() { "hannah" };
        bool expected = true;

        // Act
        bool result = Palindrome.IsPalindrome(words);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> words = new() { "hello", "world" };
        bool expected = false;

        // Act
        bool result = Palindrome.IsPalindrome(words);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new() { "Hannah", "Level", "Racecar" };
        bool expected = true;

        // Act
        bool result = Palindrome.IsPalindrome(words);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
