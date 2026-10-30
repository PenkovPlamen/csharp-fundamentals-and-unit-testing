using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveLessThanOrEqualToTests
{
    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmtyList()
    {
        List<int> input = new();
        List<int> expected = new();

        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, 5);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmtyList()
    {
        List<int> input = new() { 1, 2, 3, 4, 5 };
        List<int> expected = new();

        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, 5);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
    {
        List<int> input = new() { 6, 7, 8, 9, 10 };
        List<int> expected = new() { 6, 7, 8, 9, 10 };

        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, 5);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
    {
        List<int> input = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> expected = new() { 6, 7, 8, 9, 10 };

        List<int> result = ListRemover.RemoveElementsLessThanOrEqualTo(input, 5);

        Assert.That(result, Is.EqualTo(expected));
    }
}
