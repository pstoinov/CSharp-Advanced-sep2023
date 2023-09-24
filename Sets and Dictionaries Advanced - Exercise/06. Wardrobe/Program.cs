﻿Dictionary<string, Dictionary<string, int>> colorsClothes = new Dictionary<string, Dictionary<string, int>>();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] tokens = Console.ReadLine().Split(new string[] { " ->", "," }, StringSplitOptions.RemoveEmptyEntries);
    string color = tokens[0];

    if (!colorsClothes.ContainsKey(color))
    {
        colorsClothes.Add(color, new Dictionary<string, int>());
    }

    for (int j = 1; j < tokens.Length; j++)
    {
        string currentWear = tokens[j];

        if (colorsClothes[color].ContainsKey(currentWear))
        {
            colorsClothes[color].Add(currentWear, 0);
        }
        colorsClothes[color][currentWear]++;
    }
}
string[] findParams = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

foreach (var colorClothes in colorsClothes)
{
    Console.WriteLine($"{colorClothes.Key} clothes:");

    foreach (var wearCount in colorClothes.Value)
    {
        string printItem = $"* {wearCount.Key} - {wearCount.Value}";
        string color = findParams[0];
        string wear = findParams[1];
        if (colorClothes.Key == color && wearCount.Key == wear)
        {
            printItem += " (found!)";
        }

        Console.WriteLine(printItem);
    }
}
