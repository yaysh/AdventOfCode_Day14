namespace AdventOfCode2021;

public static class Polymer
{
    public static Dictionary<string, char> Template = new()
    {
        {"CH", 'B'},
        {"HH", 'N'},
        {"CB", 'H'},
        {"NH", 'C'},
        {"HB", 'C'},
        {"HC", 'B'},
        {"HN", 'C'},
        {"NN", 'C'},
        {"BH", 'H'},
        {"NC", 'B'},
        {"NB", 'B'},
        {"BN", 'B'},
        {"BB", 'N'},
        {"BC", 'B'},
        {"CC", 'N'},
        {"CN", 'C'},
    };
}