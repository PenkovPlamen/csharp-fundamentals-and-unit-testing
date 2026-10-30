using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class NumberUtilitiesTests
{
    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenNoNumbersDivisibleByThree()
    {
        List<int> numbers = new() { 2, 4, 7 };
        string expected = string.Empty;

        string result = NumberUtilities.GetDivisibleByThree(numbers);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenListIsEmpty()
    {
        List<int> numbers = new();
        string expected = string.Empty;

        string result = NumberUtilities.GetDivisibleByThree(numbers);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnEmptyString_WhenListIsNull()
    {
        List<int> numbers = null;
        string expected = string.Empty;

        string result = NumberUtilities.GetDivisibleByThree(numbers);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnSingleNumber_WhenOnlyOneDivisibleByThree()
    {
        List<int> numbers = new() { 3 };
        string expected = "3";

        string result = NumberUtilities.GetDivisibleByThree(numbers);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnOnlyNumbersDivisibleByThree_WhenListHasMixedValues()
    {
        List<int> numbers = new() { 1, 2, 3 };
        string expected = "3";

        string result = NumberUtilities.GetDivisibleByThree(numbers);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldHandleNegativeNumbersCorrectly()
    {
        List<int> numbers = new() { 1, 2, -3 };
        string expected = "-3";

        string result = NumberUtilities.GetDivisibleByThree(numbers);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetDivisibleByThree_ShouldReturnUniqueNumbers_WhenListHasDuplicates()
    {
        List<int> numbers = new() { 1, 2, 3, 3};
        string expected = "3";

        string result = NumberUtilities.GetDivisibleByThree(numbers);

        Assert.That(result, Is.EqualTo(expected));
    }

}
