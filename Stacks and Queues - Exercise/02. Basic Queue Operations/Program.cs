
int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int valuesToPush = values[0];
int valueToPop = values[1];
int lookUpValue = values[2];

Queue<int> stack = new Queue<int>(input.Take(valuesToPush));

//for (int i = 0; i < valuesToPush; i++)
//{
//    stack.Push(input[i]);
//}

while (stack.Count > 0 && valueToPop > 0)
{
    stack.Dequeue();
    valueToPop--;
}

if (stack.Contains(lookUpValue))
{
    Console.WriteLine("true");
}
else if (stack.Count == 0)
{
    Console.WriteLine("0");
}
else
{
    Console.WriteLine(stack.Min());
}