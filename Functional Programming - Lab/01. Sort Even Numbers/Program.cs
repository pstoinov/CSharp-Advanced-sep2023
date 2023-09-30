

List<int> evenNumbers = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Where(isEven)
    .OrderBy(x =>x )
    .ToList();


Console.WriteLine(string.Join(", ", evenNumbers));

bool isEven(int x)
{
    return x % 2 == 0;
}