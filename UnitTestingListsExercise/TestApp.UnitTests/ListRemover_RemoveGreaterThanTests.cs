using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        List<int> input = new();
        List<int> expected = new();

        List<int> result = ListRemover.RemoveElementsGreaterThan(input, 5);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        List<int> input = new() { 6, 7, 8, 9, 10 };
        List<int> expected = new();

        List<int> result = ListRemover.RemoveElementsGreaterThan(input, 5);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        List<int> input = new() { 1, 2, 3, 4, };
        List<int> expected = new() { 1, 2, 3, 4, };

        List<int> result = ListRemover.RemoveElementsGreaterThan(input, 5);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        List<int> input = new() { 1, 2, 3, 4, 5, 6 };
        List<int> expected = new() { 1, 2, 3, 4, 5 };

        List<int> result = ListRemover.RemoveElementsGreaterThan(input, 5);

        Assert.That(result, Is.EqualTo(expected));
    }
}
