int[] sizeOfMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int rows = sizeOfMatrix[0];
int cols = sizeOfMatrix[1];

char[,] matrix = new char[rows, cols];

int startRow = 0;
int startCol = 0;

int currentRow = 0;
int currentCol = 0;


for (int row = 0; row < rows; row++)
{
    string currentMatrixRead = Console.ReadLine();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = currentMatrixRead[col];
        if (matrix[row, col] == 'B')
        {
            (startRow, currentRow) = (row, row);
            (startCol, currentCol) = (col, col);
        }
    }


}

bool isOutsideMatrix = false;
while (true) 
{
    string command = Console.ReadLine();

    if (command == "left")
    {
        if (currentCol == 0)
        {
            if (matrix[currentRow, currentCol] == '-')
            {
                matrix[currentRow, currentCol] = '.';
            }
            Console.WriteLine("The delivery is late. Order is canceled.");
            isOutsideMatrix = true;
            break;
        }

        if (matrix[currentRow, currentCol - 1] == '*')
        {
            continue;
        }
        if ((matrix[currentRow, currentCol] != 'R'))
        {
            matrix[currentRow, currentCol] = '.';
        }
        currentCol--;
    }
    else if (command == "right")
    {
        if (currentCol == cols -1)
        {
            if (matrix[currentRow, currentCol] == '-')
            {
                matrix[currentRow, currentCol] = '.';
            }
            Console.WriteLine("The delivery is late. Order is canceled.");
            isOutsideMatrix = true;
            break;
        }

        if (matrix[currentRow, currentCol + 1] == '*')
        {
            continue;
        }
        if ((matrix[currentRow, currentCol] != 'R'))
        {
            matrix[currentRow, currentCol] = '.';
        }
        currentCol++;
    }
    else if (command == "up")
    {
        if (currentRow == 0)
        {
            if (matrix[currentRow, currentCol] == '-')
            {
                matrix[currentRow, currentCol] = '.';
            }
            Console.WriteLine("The delivery is late. Order is canceled.");

            isOutsideMatrix = true;

            break;
        }

        if (matrix[currentRow - 1, currentCol] == '*')
        {
            continue;
        }
        if ((matrix[currentRow, currentCol] != 'R'))
        {
            matrix[currentRow, currentCol] = '.';
        }
        currentRow--;
    }
    else if (command == "down")
    {
        if (currentRow == rows - 1)
        {
            if (matrix[currentRow, currentCol] == '-')
            {
                matrix[currentRow, currentCol] = '.';
            }
            Console.WriteLine("The delivery is late. Order is canceled.");
            isOutsideMatrix = true;

            break;
        }

        if (matrix[currentRow + 1, currentCol] == '*')
        {
            continue;
        }
        if ((matrix[currentRow, currentCol] != 'R'))
        {
            matrix[currentRow, currentCol] = '.';
        }
        currentRow++;
    }

    if (matrix[currentRow, currentCol] == 'P')
    {
        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
        matrix[currentRow, currentCol] = 'R';
        continue;
    }

    if (matrix[currentRow, currentCol] == 'A')
    {
        Console.WriteLine("Pizza is delivered on time! Next order...");
        matrix[currentRow, currentCol] = 'P';
        break;
    }
}

if (isOutsideMatrix)
{
    matrix[startRow, startCol] = ' ';
}
else
{
    matrix[startRow, startCol] = 'B';
}


for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}