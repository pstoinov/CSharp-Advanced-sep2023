
using System.Net.Cache;

namespace _06.EqualityLogic;
public class StartUp
{
    public static void Main(string[] args)
    {
        HashSet<Person> hashset = new HashSet<Person>();
        HashSet<Person> sortedSet = new HashSet<Person>();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] personPros = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Person person = new Person() { Name = personPros[0], Age = int.Parse(personPros[1]) };
            hashset.Add(person);
            sortedSet.Add(person);

        }
        Console.WriteLine(hashset.Count);
        Console.WriteLine(sortedSet.Count);

    }
}