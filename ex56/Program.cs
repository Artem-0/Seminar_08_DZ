// Задача 56. Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GenerateMatrix(int row, int col)
{
    Random rand = new Random();
    int[,] matrix = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rand.Next(10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int SumOfRow(int[,] matrix, int row)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum += matrix[row, i];
    }
    return sum;
}

int[] MinimumSumRow(int[,] matrix)
{
    int[] minRowAndSum = new int[2];
    int minSumRow = SumOfRow(matrix, 0);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (SumOfRow(matrix, i) < minSumRow)
        {
            minSumRow = SumOfRow(matrix, i);
            minRowAndSum[0] = i;
            minRowAndSum[1] = SumOfRow(matrix, i);
        }
    }
    return minRowAndSum;
}

// --------------------------------------------------------

int[,] matrix = GenerateMatrix(4, 3);
System.Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);

int[] minRowAndSum = MinimumSumRow(matrix);
System.Console.WriteLine($"Сумма наименьшей строки (строка {minRowAndSum[0] + 1}): {minRowAndSum[1]}");