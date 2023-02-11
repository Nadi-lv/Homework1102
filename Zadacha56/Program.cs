
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void NumberStrSMinSumElem (int[,] array)
{
    int minStr = 0;
    int minSumStr = 0;
    int sumStr = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minStr += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumStr += array[i, j];
        if (sumStr < minStr)
        {
            minStr = sumStr;
            minSumStr = i;
        }
        sumStr = 0;
    }
    Console.Write($"{minSumStr + 1} строка");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] table = new int[3, 4];
FillArrayRandom(table);
Console.WriteLine("Сгенерированный массив:");
PrintArray(table);
NumberStrSMinSumElem(table);

