
namespace GenericArrayCreator;
public class StartUp
{
    public static void Main(string[] args)
    {
        string[] list = ArrayCreator.Create(3, "Robcho");
        Console.WriteLine(string.Join(", ", list));
    }
}