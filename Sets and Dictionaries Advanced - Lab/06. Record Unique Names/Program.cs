﻿int count = int.Parse(Console.ReadLine());
HashSet<string> names = new HashSet<string>();

for (int i = 0; i < count; i++)
{
    string name = Console.ReadLine();
    names.Add(name);
}

foreach (var name in names)
{
    Console.WriteLine(name);
}