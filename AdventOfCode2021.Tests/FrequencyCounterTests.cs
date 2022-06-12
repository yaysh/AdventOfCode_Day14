using NUnit.Framework;

namespace AdventOfCode2021.Tests;

public class FrequencyCounterTests
{
    [Test]
    public void TestSimple_Works()
    {
        var (mostCommon, leastCommon) = FrequencyCounter.GetMostAndLeastCommon("NNBC");
        
        Assert.AreEqual(2, mostCommon.Value, "Should be 2");
        Assert.AreEqual('N', mostCommon.Key, "Should be N");
        Assert.AreEqual(1, leastCommon.Value, "Should be 1");
    }
    
    [Test]
    public void UpdatesLeastCommon_Works()
    {
        var (mostCommon, leastCommon) = FrequencyCounter.GetMostAndLeastCommon("ABCDEFA");
        
        Assert.AreEqual(2, mostCommon.Value, "Should be 2");
        Assert.AreEqual(1, leastCommon.Value, "Should be 1");
    }
}