
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int>  evenNumQueue  = new Queue<int>();

foreach (var num in input)
{
    if (num % 2 == 0)
    {
        evenNumQueue.Enqueue(num);
    }
}

Console.WriteLine(string.Join(", ", evenNumQueue ));