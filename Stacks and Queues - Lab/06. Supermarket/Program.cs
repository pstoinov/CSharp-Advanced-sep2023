

string command = Console.ReadLine();
Queue<string> customersQueue  = new Queue<string>();

while (command != "End")
{
    if (command != "Paid")
    {
        customersQueue.Enqueue(command);
    }
    else
    {
        int customersToProcess = customersQueue.Count;
        for (int i = 0; i < customersToProcess; i++)
        {
            Console.WriteLine(customersQueue.Dequeue());

        }
    }
    command = Console.ReadLine();
}
Console.WriteLine($"{customersQueue.Count} people remaining.");