    int matrixSize = int.Parse(Console.ReadLine());


    int[,] matrix = new int[matrixSize, matrixSize];
    for (int i = 0; i < matrixSize; i++)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int j = 0; j < matrixSize; j++)
        {

            matrix[i, j] = input[j];
        }
    }

    int sum = 0;
    for (int i = 0; i < matrixSize; i++)
    {
        for (int j = i; j < i + 1; j++)
        {
            sum += matrix[i, j];
        }
    }
    Console.WriteLine(sum);