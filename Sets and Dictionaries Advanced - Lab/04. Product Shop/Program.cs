Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

string command = Console.ReadLine();

while (command != "Revision")
{
    string[] partsCommand = command.Split(", ");
    string shop = partsCommand[0];
    string product = partsCommand[1];
    double price = double.Parse(partsCommand[2]);
    if (!shops.ContainsKey(shop))
    {
        shops.Add(shop, new  Dictionary<string, double>());
    }

    shops[shop].Add(product, price);

    command = Console.ReadLine();
}

foreach (var shop in shops.OrderBy(s => s.Key))
{
    Console.WriteLine($"{shop.Key}->");
    foreach (var product in shop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
    
}