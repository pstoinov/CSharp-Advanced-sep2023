
namespace GenericSwapMethodStrings;
public class StartUp
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        //Box<string> list = new Box<string>();
        //Box<int> list = new Box<int>();
        Box<double> list = new Box<double>();



        for (int i = 0; i < n; i++)
        {
            //string input = Console.ReadLine();
            //int input = int.Parse(Console.ReadLine());
            double input = double.Parse(Console.ReadLine());

            list.Add(input);
        }

        //int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        //list.Swap(indexes[0], indexes[1]);

        //Console.WriteLine(list.ToString());
        //string compare = Console.ReadLine();
        double compare = double.Parse(Console.ReadLine());


        List<double> greaterItems = list.GetGreaterItems(compare);

        Console.WriteLine(greaterItems.Count);

    }
}