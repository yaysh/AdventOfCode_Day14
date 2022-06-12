// See https://aka.ms/new-console-template for more information

using AdventOfCode2021;

var day14 = new Day14(Polymer.Template);

var (mostCommon, leastCommon) = day14.GetMostCommonSubtractedWithLeastCommon("NNCB", 10);
Console.WriteLine($"Most common character {mostCommon.Key}: {mostCommon.Value}");
Console.WriteLine($"Least common character {leastCommon.Key}: {leastCommon.Value}");
Console.WriteLine($"The difference: {mostCommon.Value} - {leastCommon.Value} = {mostCommon.Value - leastCommon.Value}");


