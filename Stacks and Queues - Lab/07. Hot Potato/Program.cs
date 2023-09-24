
Queue<string> playersQueue  = new Queue<string>(Console.ReadLine().Split());

int tossCount = int.Parse(Console.ReadLine());
int tosses = 0;

while (playersQueue.Count > 1)
{
    tosses++;
    string playerWithPatato = playersQueue.Dequeue();
    if (tosses == tossCount)
    {
        tosses = 0;
        Console.WriteLine($"Removed {playerWithPatato}");
    }
    else
    {
        playersQueue.Enqueue(playerWithPatato);
    }
}

Console.WriteLine($"Last is {playersQueue.Dequeue()}");