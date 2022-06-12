namespace AdventOfCode2021;

public static class FrequencyCounter
{

    public static (KeyValuePair<char, int>, KeyValuePair<char, int>) GetMostAndLeastCommon(string str)
    {
        var frequencyDict = new Dictionary<char, int>();
        foreach (var c in str)
        {
            if (frequencyDict.ContainsKey(c))
                frequencyDict[c] += 1;
            else
                frequencyDict[c] = 1;
        }

        var sortedDict = frequencyDict
            .OrderByDescending(x => x.Value)
            .ToArray();
        
        return (sortedDict.First(), sortedDict.Last());
    }
}