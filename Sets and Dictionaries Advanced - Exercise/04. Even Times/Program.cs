﻿
Dictionary<int, int> numbers = new Dictionary<int, int>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (!numbers.ContainsKey(number))
    {
        numbers.Add(number, 0);

    }
    numbers[number]++;
}
int result = numbers.Single(n => n.Value % 2 == 0).Key;
Console.WriteLine(result);