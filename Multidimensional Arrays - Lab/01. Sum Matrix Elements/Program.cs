
int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = matrixSize[0];
int cols = matrixSize[1];

int[,] matrix = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int j = 0; j < cols; j++)
    {

        matrix[i, j] = input[j];
    }
}

int sum = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        sum += matrix[i, j];
    }
}
Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);