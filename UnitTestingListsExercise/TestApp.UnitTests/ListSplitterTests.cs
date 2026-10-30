using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        List<int> input = new();
        List<int> expectedEven = new();
        List<int> expectedOdd = new();

        List<int> resultEven = ListSplitter.SplitEvenAndOdd(input).evens;
        List<int> resultOdd = ListSplitter.SplitEvenAndOdd(input).odds;

        Assert.That(resultEven, Is.EqualTo(expectedEven));
        Assert.That(resultOdd, Is.EqualTo(expectedOdd));
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        List<int> input = new() { 2, 4, 6, 8, 10 };
        List<int> expectedEven = new() { 2, 4, 6, 8, 10 };
        List<int> expectedOdd = new();

        List<int> resultEven = ListSplitter.SplitEvenAndOdd(input).evens;
        List<int> resultOdd = ListSplitter.SplitEvenAndOdd(input).odds;

        Assert.That(resultEven, Is.EqualTo(expectedEven));
        Assert.That(resultOdd, Is.EqualTo(expectedOdd));
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        List<int> input = new() { 1, 3, 5, 7, 9 };
        List<int> expectedEven = new();
        List<int> expectedOdd = new() { 1, 3, 5, 7, 9 };

        List<int> resultEven = ListSplitter.SplitEvenAndOdd(input).evens;
        List<int> resultOdd = ListSplitter.SplitEvenAndOdd(input).odds;

        Assert.That(resultEven, Is.EqualTo(expectedEven));
        Assert.That(resultOdd, Is.EqualTo(expectedOdd));
    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        List<int> input = new() { 1, 2, 3, 4, 5 };
        List<int> expectedEven = new() { 2, 4 };
        List<int> expectedOdd = new() { 1, 3, 5 };

        List<int> resultEven = ListSplitter.SplitEvenAndOdd(input).evens;
        List<int> resultOdd = ListSplitter.SplitEvenAndOdd(input).odds;

        Assert.That(resultEven, Is.EqualTo(expectedEven));
        Assert.That(resultOdd, Is.EqualTo(expectedOdd));
    }
}
