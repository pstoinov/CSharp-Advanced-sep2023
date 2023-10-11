
namespace Threeuple;
public class StartUp
{
    public static void Main(string[] args)
    {
        string[] personTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] drinkTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] numbersTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        Threeuple<string, string, string> nameAdress = new($"{personTokens[0]} {personTokens[1]}", personTokens[2], string.Join(" ", personTokens[3..]));
        Threeuple<string, int, bool> drinkBeer = new($"{drinkTokens[0]}", int.Parse(drinkTokens[1]),drinkTokens[2] == "drunk");
        Threeuple<string, double, string> numbers = new(numbersTokens[0], double.Parse(numbersTokens[1]), $"{numbersTokens[2]}");

        Console.WriteLine(nameAdress);
        Console.WriteLine(drinkBeer);
        Console.WriteLine(numbers);
    }
}