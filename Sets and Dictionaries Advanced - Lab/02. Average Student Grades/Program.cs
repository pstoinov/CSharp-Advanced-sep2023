using System.Diagnostics.CodeAnalysis;

int n = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string name = tokens[0];
    decimal grade = decimal.Parse(tokens[1]);

    if (!students.ContainsKey(name))
    {
        students.Add(name, new List<decimal>());
    }
       
    students[name].Add(grade);
}

foreach (var student in students)
{
    string formattedGrades = string.Join(" ", student.Value.Select(g => g.ToString("F2")));
    Console.WriteLine($"{student.Key} -> {formattedGrades} (avg: {student.Value.Average():F2})");
}   