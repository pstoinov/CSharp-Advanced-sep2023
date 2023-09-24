SortedDictionary<char, int> charsCounts = new SortedDictionary<char, int>();

string input = Console.ReadLine();

foreach (var ch in input)
{
    if (!charsCounts.ContainsKey(ch))
    {
        charsCounts.Add(ch, 0);
    }
    charsCounts[ch]++;
}

foreach (var charCount in charsCounts)
{
    Console.WriteLine($"{charCount.Key}: {charCount.Value} time/s");
}

