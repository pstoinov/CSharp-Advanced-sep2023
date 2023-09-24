HashSet<string> licensePlate = new HashSet<string>();

string command = Console.ReadLine();

while (command != "END")
{
    string action = command.Split(", ")[0];
    string plate = command.Split(", ")[1];

    if (action == "IN")
    {
        licensePlate.Add(plate);
    }
    else if (action == "OUT" && licensePlate.Contains(plate)) 
    {
        licensePlate.Remove(plate);
    }
    command = Console.ReadLine();
}

if (licensePlate.Any())
{
    foreach (var plate in licensePlate)
    {
        Console.WriteLine(plate);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}