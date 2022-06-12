using NUnit.Framework;

namespace AdventOfCode2021.Tests;

public class Day14Tests
{
    private readonly Day14 _day14;
    
    public Day14Tests()
    {
        var polymerTemplate = Polymer.Template;
        _day14 = new Day14(polymerTemplate);
    }

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void OneIteration_Works()
    {
        const string input = "NNCB";

        var res = _day14.RunIterations(input, 1);
        
        Assert.AreEqual("NCNBCHB", res, "uh oh");
    }
    
    [Test]
    public void TwoIterations_Works()
    {
        const string input = "NNCB";

        var res = _day14.RunIterations(input, 2);
        
        Assert.AreEqual("NBCCNBBBCBHCB", res, "uh oh");
    }
    
    [Test]
    public void ThreeIterations_Works()
    {
        const string input = "NNCB";

        var res = _day14.RunIterations(input, 3);
        
        Assert.AreEqual("NBBBCNCCNBBNBNBBCHBHHBCHB", res, "uh oh");
    }
    
    [Test]
    public void FourIterations_Works()
    {
        const string input = "NNCB";

        var res = _day14.RunIterations(input, 4);
        
        Assert.AreEqual("NBBNBNBBCCNBCNCCNBBNBBNBBBNBBNBBCBHCBHHNHCBBCBHCB", res, "uh oh");
    }
    
    [Test]
    public void TenIterations_CorrectLength()
    {
        const string input = "NNCB";

        var res = _day14.RunIterations(input, 10);
        
        Assert.AreEqual(3073, res.Length, "uh oh");
    }
    
    [Test]
    public void CalculateDifference_Works()
    {
        const string input = "NNCB";

        var res = _day14.GetMostCommonSubtractedWithLeastCommon(input, 10);
        
        Assert.AreEqual(1588, res, "uh oh");
    }
}