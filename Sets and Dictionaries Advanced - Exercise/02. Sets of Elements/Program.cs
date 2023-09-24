
string countOfElements = Console.ReadLine();
HashSet<int> firstSet = new HashSet<int>();
HashSet<int> secondSet = new HashSet<int>();


int firstSetSize = int.Parse(countOfElements.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0]);
int secondSetSize = int.Parse(countOfElements.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);

fillUpSets(firstSetSize, firstSet);
fillUpSets(secondSetSize, secondSet);

//foreach (var element in firstSet)
//{
//    if (secondSet.Contains(element))
//    {
//        Console.Write(element+" ");  
//    }
//}

firstSet.IntersectWith(secondSet);

Console.WriteLine(string.Join(" ", firstSet));


static void fillUpSets(int sizeOfSet, HashSet<int> set)
{
    for (int i = 0; i < sizeOfSet; i++)
    {
        int elementToAdd = int.Parse(Console.ReadLine());
        set.Add(elementToAdd);
    }
}