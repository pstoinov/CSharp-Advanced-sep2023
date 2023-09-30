

Action<string[]> printNamesWithTitle = names =>
{
    foreach (var name in names)
    {
        Console.WriteLine("Sir " + name);
    }
};

string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

printNamesWithTitle(strings);

