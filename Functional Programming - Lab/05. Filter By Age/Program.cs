


List<Student> students = new List<Student>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string name = input[0];
    int age = int.Parse(input[1]);

    Student student = new Student(){Name = name, Age = age};
    students.Add(student);
}

string filterType = Console.ReadLine();
int filterNumber = int.Parse(Console.ReadLine());

Func<Student, int, bool> filter = filterGenerator(filterType, filterNumber);


string format = Console.ReadLine();

Func<Student, int, bool> filterGenerator(string filterType)
{
    if (filterType == "older")
    {
        filter = (student, number) => student.Age >= number;
    }
    if (filterType == "younger")
    {
        filter = (student, number) => student.Age >= number;
    }
    return filter;
}

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}
