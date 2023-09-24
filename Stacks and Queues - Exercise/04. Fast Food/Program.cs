
int qtyFood = int.Parse(Console.ReadLine());

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> orderQueue  = new Queue<int>(input);

Console.WriteLine(orderQueue.Max());

while (orderQueue.Count > 0 && qtyFood > 0)
{
    int currentOrder = orderQueue.Peek();

    if (qtyFood - currentOrder >=0)
    {
        orderQueue.Dequeue();
        qtyFood -= currentOrder;
    }
    else
    {
        break;
    }
}

if (orderQueue.Count == 0)
{
    Console.WriteLine("Orders complete");
}
else
{
    Console.WriteLine($"Orders left: {string.Join(" ", orderQueue)}");
}