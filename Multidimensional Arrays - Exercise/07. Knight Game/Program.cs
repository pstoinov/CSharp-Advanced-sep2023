int size = int.Parse(Console.ReadLine());

if (size < 3)
{
    Console.WriteLine(0);
    return;
}

char[,] matrix = new char[size, size];

//Прочитане на матрица от конзолата
for (int row = 0; row <= size - 1; row++) //всички редове от първия до последния
{
    char[] symbols = Console.ReadLine().ToArray();
    for (int col = 0; col <= size - 1; col++)
    {
        matrix[row, col] = symbols[col];
        
    }
}