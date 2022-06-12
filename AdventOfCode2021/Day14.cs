using System.Text;

namespace AdventOfCode2021;

public class Day14
{
    private readonly Dictionary<string, char> _polymerTemplate;

    public Day14(Dictionary<string, char> polymerTemplate)
    {
        _polymerTemplate = polymerTemplate;
    }
    
    public (KeyValuePair<char, int>, KeyValuePair<char, int>) GetMostCommonSubtractedWithLeastCommon(string input, int iterations)
    {
        var result = RunIterations(input, iterations);
        return FrequencyCounter.GetMostAndLeastCommon(result);
    }
    
    public string RunIterations(string input, int iterations)
    {
        var res = input;
        while (iterations > 0)
        {
            res = RunIteration(res);
            iterations--;
        }

        return res;
    }
    

    private string RunIteration(string input)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < input.Length; i++)
        {
            if (i == input.Length - 1)
            {
                sb.Append(input[i]);
                break;
            }

            sb.Append(input[i]);
            var polymerKey = $"{input[i]}{input[i + 1]}";
            sb.Append(_polymerTemplate[polymerKey]);
        }

        return sb.ToString();
    }
}