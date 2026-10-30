using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> input = new() { 5, 7, 9 };
        List<double> expected = new() { 2.2360679774997898, 2.6457513110645907, 3 };
        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> input = new() { 0 };
        List<int> expected = new() { 0 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);
        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        // TODO: finish test
        List<int> input = new();
        List<double> expected = new();

        List<double> result = NumberProcessor.ProcessNumbers(input);
        CollectionAssert.AreEqual(expected, result);
    }
}
