Queue<int> monsterArmor = new Queue<int> (Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Stack<int> soldierAttack = new Stack<int>(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
int monsterKilled = 0;

while (monsterArmor.Any() && soldierAttack.Any())
{
    int armor = monsterArmor.Dequeue();
    int strike = soldierAttack.Pop();

    if (strike >= armor)
    {
        monsterKilled++;
        strike -= armor;
        if (soldierAttack.Any()) 
        { 
            int nextStrike = soldierAttack.Pop(); 
            nextStrike += strike; 
            soldierAttack.Push(nextStrike);
        }
        else if (strike > 0) { soldierAttack.Push(strike); }
    }
    else
    {
        armor -=strike;
        monsterArmor.Enqueue(armor);
    }
}

if (!monsterArmor.Any()) 
{
    Console.WriteLine("All monsters have been killed!");
}

if (!soldierAttack.Any())
{
    Console.WriteLine("The soldier has been defeated.");
}
Console.WriteLine($"Total monsters killed: {monsterKilled}");
