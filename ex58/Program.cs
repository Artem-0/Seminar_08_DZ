// Задача 58. Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

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

int[,] MartixMultiplication(int[,] A, int[,] B)
{
    if (A.GetLength(1) != B.GetLength(0))
        System.Console.WriteLine("Матрицы нельзя перемножить");
    int[,] C = new int[A.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            for (int k = 0; k < B.GetLength(0); k++)
            {
                C[i, j] += A[i, k] * B[k, j];
            }
        }
    }
    return C;
}

// --------------------------------------------------------

int[,] A = GenerateMatrix(4, 3);
System.Console.WriteLine("Исходная матрица A:");
PrintMatrix(A);

int[,] B = GenerateMatrix(3, 4);
System.Console.WriteLine("Исходная матрица B:");
PrintMatrix(B);

int[,] C = MartixMultiplication(A, B);
System.Console.WriteLine("Результирующая матрица C:");
PrintMatrix(C);