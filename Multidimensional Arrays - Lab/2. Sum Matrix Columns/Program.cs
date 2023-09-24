

int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = matrixSize[0];
int cols = matrixSize[1];

int[,] matrix = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for (int j = 0; j < cols; j++)
    {

        matrix[i, j] = input[j];
    }
}

for (int i = 0; i < cols; i++)
{
    int sum = 0;

    for (int j = 0; j < rows; j++)
    {
        sum += matrix[j, i];
    }
    Console.WriteLine(sum);
}
