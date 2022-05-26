// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int rows = 5;
int cols = 2;
int[,] matrix = new int[rows, cols];

FillMatrix();
Console.WriteLine("Дан массив: ");
PrintMatrix();
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов - {MinString() + 1}");

void FillMatrix()
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

void PrintMatrix()
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

int MinString()
{
    int sumString = 0;
    int sumMin = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumMin += matrix[0, j];
    }
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumString = 0;
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            sumString = matrix[i, j] + matrix[i, j + 1];
        }
        if (sumString < sumMin)
        {
            sumMin = sumString;
            minRow = i;
        }
    }
    return minRow;
}