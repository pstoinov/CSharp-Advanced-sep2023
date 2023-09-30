

    Func<string, double> parser = s => double.Parse(s);
    Func<double, double> vat = n => n*1.2;
    List<Double> numbers = Console.ReadLine().Split(", ").Select(parser).Select(vat).ToList();

    foreach (var item in numbers)
    {
        Console.WriteLine($"{item:F2}");
    }