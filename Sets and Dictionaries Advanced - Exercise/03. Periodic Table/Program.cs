
int n = int.Parse(Console.ReadLine());
SortedSet<string> elementList = new SortedSet<string>();

//List<string> elementsList = new List<string>();

for (int i = 0; i < n; i++)
{
   string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

   elementList.UnionWith(elements);

//    foreach (var element in elements)
//    {
//        if (!elementsList.Contains(element))
//        {
//            elementsList.Add(element);
//        }
//    }
}
Console.WriteLine(string.Join(" ", elementList));