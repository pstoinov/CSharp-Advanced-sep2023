﻿
int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

Stack<int> racks = new Stack<int>(input);

int capacity = int.Parse(Console.ReadLine());
int totalUserRacks = 1;
int currentCapacity = 0;
while (racks.Count > 0)
{
    int currentValue = racks.Pop();
    if (currentValue + currentCapacity <= capacity)
    {
        currentCapacity += currentValue;
    }
    else
    {
        totalUserRacks++;
        currentCapacity = currentValue;
    }
}

Console.WriteLine(totalUserRacks);