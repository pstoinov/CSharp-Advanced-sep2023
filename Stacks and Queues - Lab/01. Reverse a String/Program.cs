

using System.Collections;

string input = Console.ReadLine();

Stack<char> reverseChars  = new Stack<char>();

foreach (var item in input)
{
    reverseChars.Push(item);
}

while (reverseChars.Count > 0)
{
    Console.Write(reverseChars.Pop());
}