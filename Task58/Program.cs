//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateArray()
{
    Console.WriteLine("Задаю матрицу:");

    int rows = 2;

    int columns = 2;
    int[,] array = new int[rows, columns];

    return array;
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] multMaxrix(int[,] array1, int[,] array2)
{
    
    int[,] mult = new int[array1.GetLength(1), array2.GetLength(0)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for(int k = 0; k<array2.GetLength(0); k++)
            mult[i, j] += array1[i, k] * array2[k,j];
            
        }
    }
    return mult;
}


int[,] firstArray2D = CreateArray();
FillArray(firstArray2D);
Print2DArray(firstArray2D);
int[,] secondArray2D = CreateArray();
FillArray(secondArray2D);
Print2DArray(secondArray2D);
Console.WriteLine("Вывод поизведения матриц:");
int[,] thirdArray2D = multMaxrix(firstArray2D, secondArray2D);
Print2DArray(thirdArray2D);