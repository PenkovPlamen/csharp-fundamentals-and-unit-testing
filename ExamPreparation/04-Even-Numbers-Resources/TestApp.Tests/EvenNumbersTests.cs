using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class EvenNumbersTests
{
    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsErrorMessage_WhenStartIsGreaterThanEnd()
    {
        int start = 10;
        int end = 5;
        string expected = "Start number should be smaller than end number.";

        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsErrorMessage_WhenStartIsNegative()
    {
        int start = -1;
        int end = 5;
        string expected = "Start number should be positive number.";

        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEmptyResult_WhenStartAndEndAreEqualOddNumbers()
    {
        int start = 5;
        int end = 5;
        string expected = "Empty result";

        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsSingleEvenNumber_WhenStartAndEndAreEqualEvenNumbers()
    {
        int start = 4;
        int end = 4;
        string expected = "4";

        string result = EvenNumbers.GetEvenNumbersInRange(start, end);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenRangeHasEvens()
    {
        int start = 1;
        int end = 10;
        string expected = "2, 4, 6, 8, 10";

        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenStartAndEndAreEvenNumbers()
    {
        int start = 2;
        int end = 10;
        string expected = "2, 4, 6, 8, 10";

        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenNumbersInRange_ReturnsEvenNumbers_WhenStartAndEndAreOddNumbers()
    {
        int start = 1;
        int end = 9;
        string expected = "2, 4, 6, 8";

        string result = EvenNumbers.GetEvenNumbersInRange(start, end);

        Assert.That(result, Is.EqualTo(expected));
    }
}
