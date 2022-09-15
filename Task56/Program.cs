// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] CreateArray()
{
    Console.WriteLine("Создаю двумерный массив...");

    int rows = new Random().Next(2, 5);

    int columns = new Random().Next(2, 5);
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
int[] arrayWithResultOfSummaryElements(int[,] array)
{
    int[] arrayOfSumElements = new int[array.GetLength(0)];
    
    for(int i=0; i<array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j<array.GetLength(1); j++)
        {
             sum = sum+array[i,j];
             arrayOfSumElements[i]=sum;
        }
        

    }
    return arrayOfSumElements;
}
int FindMinElement(int[] array)
{
    int min = array[0];
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i]<min)    min = array[i];
    }
    return min;
}
int FindNeededRow(int minValue, int[] array)
{
    int neededRow = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i] ==minValue) neededRow = i+1;

    }
    return neededRow;
}

int[,] array2D = CreateArray();
FillArray(array2D);
Print2DArray(array2D);
int[] array1D = arrayWithResultOfSummaryElements(array2D); 
int minElement = FindMinElement(array1D);
int neededRow = FindNeededRow(minElement,array1D);
Console.WriteLine("");
Console.WriteLine("Строка двумерного массива с наименьшей суммой элементов - это строка номер " + neededRow);
