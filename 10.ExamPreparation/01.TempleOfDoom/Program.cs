using System.Collections.Generic;
using System;

Queue<int> tools = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Stack<int> substances = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
List<int> challenges = new List<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));


while (true)
{
    int tool = tools.Dequeue();
    int substance = substances.Pop();
    int resuult = tool * substance;

    if (challenges.Contains(resuult))
    {
        challenges.Remove(resuult);
    }
    else
    {
        tool++;
        substance--;
        tools.Enqueue(tool);

        if (substance > 0)
        {
            substances.Push(substance);
        }
    }

    if ((!tools.Any() || !substances.Any()) && challenges.Any()) 
    {
        Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
        break;
    }
    if (!challenges.Any())
    {
        Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
        break;
    }
}

if (tools.Any())
{
    Console.WriteLine($"Tools: {string.Join(", ", tools)}");
}

if (substances.Any())
{
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");
}

if (challenges.Any())
{
    Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
}




