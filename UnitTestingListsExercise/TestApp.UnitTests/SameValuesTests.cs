using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        List<int> firstList = new();
        List<int> secondList = new() { 1, 2, 3 };
        List<int> expected = new();

        List<int> result = SameValues.FindSameValues(firstList, secondList);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        List<int> firstList = new() { 1, 2, 3 };
        List<int> secondList = new();
        List<int> expected = new();

        List<int> result = SameValues.FindSameValues(firstList, secondList);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        List<int> firstList = new() { 1, 2, 3 };
        List<int> secondList = new() { 4, 5, 6 };
        List<int> expected = new();

        List<int> result = SameValues.FindSameValues(firstList, secondList);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        List<int> firstList = new() { 1, 2, 3 };
        List<int> secondList = new() { 1, 2, 3 };
        List<int> expected = new() { 1, 2, 3 };

        List<int> result = SameValues.FindSameValues(firstList, secondList);

        Assert.That(result, Is.EqualTo(expected));
    }
}
