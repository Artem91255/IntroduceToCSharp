// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.


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
void BubbleSort2DArray(int[,] array)
{
    bool needIteration = true;
    while (needIteration)
    {
        needIteration = false;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {

                if (array[i, j] > array[i, j - 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j - 1];
                    array[i, j - 1] = temp;
                    needIteration = true;
                }
            }

        }


    }
}


int[,] array2D = CreateArray();
FillArray(array2D);
Print2DArray(array2D);
Console.WriteLine("Сортирую созданный массив... \nМассив отсортирован: ");
SelectionSort2DArray(array2D);
Print2DArray(array2D);