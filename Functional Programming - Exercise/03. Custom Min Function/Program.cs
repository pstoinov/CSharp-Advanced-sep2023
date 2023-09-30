

Func<HashSet<int>, int> min = numbers =>
{
    //return numbers.Min();
    int min = int.MaxValue;
    foreach (var item in numbers)
    {
        if (item < min) min = item;
    }
    return min;
};

HashSet<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToHashSet();

Console.WriteLine(min(numbers));