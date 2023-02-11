
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


void ProizvMatric (int[,] array1, int[,] array2)
{
  
if (array1.GetLength(0) != array2.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}

int[,] array = new int[array1.GetLength(0), array1.GetLength(1)];

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, j] += array1[i, k] * array2[k, j];
        }
    }
}

PrintArray(array);
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

int[,] array1 = new int[2, 2];
FillArrayRandom(array1);
int[,] array2 = new int [2, 2];
FillArrayRandom(array2);
Console.WriteLine("Сгенерированныe массив 1");
PrintArray(array1);
Console.WriteLine("Сгенерированныe массив 2");
PrintArray(array2);

Console.WriteLine();
ProizvMatric(array1, array2);

