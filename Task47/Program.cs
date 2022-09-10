//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int[,] CreateArray(string text)
{
    Console.WriteLine(text);
    
    int rows = new Random().Next(1,10);
    
    int columns =new Random().Next(1,10);
    int[,] array = new int[rows,columns];
    
    return array;
}

void FillArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            array[i,j]= new Random().Next(1,10);
        }
    }
}
void Print2DArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array2D = CreateArray("Задаю двумерный массив размером m×n, заполненный случайными вещественными числами: ");
FillArray(array2D);
Print2DArray(array2D);