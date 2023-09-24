

string input = Console.ReadLine();
Stack<int>  stack = new Stack<int>();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        stack.Push(i);
    }

    if (input[i] == ')')
    {
        int openingBracketIndex = stack.Pop();
        Console.WriteLine(input.Substring(openingBracketIndex, i - openingBracketIndex + 1));
    }
}
