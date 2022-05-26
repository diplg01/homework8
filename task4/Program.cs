// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая построчно выведет элементы и их индексы.

int a = 5;
int b = 2;
int c = 3;
int[,,] array = new int[a, b, c];
int[] dictionary = new int[90];

NumberDictionary();
FillTrialArray();
Console.WriteLine();
PrintMatrix();
Console.WriteLine();
// for (int i = 0; i < 100; i++)
// {
//     Console.Write(dictionary[i] + "     ");
// }

void NumberDictionary()
{
    Random rnd = new Random();
    for (int i = 0; i < dictionary.Length; i++)
    {
        dictionary[i] = i + 10;
    }
    for (int i = 0; i < dictionary.Length; ++i)
    {
        int randomIndex = rnd.Next(dictionary.Length);
        int temp = dictionary[randomIndex];
        dictionary[randomIndex] = dictionary[i];
        dictionary[i] = temp;
    }
}

void FillTrialArray()
{
    int dictionaryIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = dictionary[dictionaryIndex];
                dictionaryIndex++;
            }
        }
    }
}

void PrintMatrix()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"Элемент с индексами ({i}, {j}, {k}) = {array[i, j, k]}");

            }
        }
    }
}