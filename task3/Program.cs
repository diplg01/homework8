// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int m = 4;
int n = 5;
int k = 2;
int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[n, k];

FillMatrix(matrix1);
FillMatrix(matrix2);
Console.WriteLine("Дана матрица A: ");
PrintMatrix(matrix1);
Console.WriteLine();
Console.WriteLine("Дана матрица B: ");
PrintMatrix(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц A и B равно:");
PrintMatrix(MatrixMulti(matrix1, matrix2));

void FillMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMulti(int[,] matrix1, int[,] matrix2)
{
    int[,] multiplication = new int[m, k];
    for (int  i = 0; i < m; i++)
    {
        for (int j = 0; j < k; j++)
        {
            for (int l = 0; l < n; l++)
            {
                multiplication[i, j] += matrix1[i, l] * matrix2[l, j];
            }
        }

    }
    return multiplication;
}