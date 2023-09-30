


List<Predicate<int>> predicates = new List<Predicate<int>>();

int endRange = int.Parse(Console.ReadLine());

HashSet<int> dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToHashSet();

int[] numbers = Enumerable.Range(1, endRange).ToArray();

foreach (var div in dividers)
{
    predicates.Add(n => n % div == 0);
}

foreach (var number in numbers)
{
    var isDevisible = true;
    foreach (var match in predicates)
    {
        if (!match(number))
        {
            isDevisible = false;
            break;
        }
    }

    if (isDevisible)
    {
        Console.Write($"{number} ");
    }
}