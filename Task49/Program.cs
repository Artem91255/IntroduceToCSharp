// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

int[,] CreateArray(string text)
{
    Console.WriteLine(text);
    Console.WriteLine("Введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows,columns];
    return array;
}
void FillArray(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            array[i,j]= i+j;
        }
    }
}
void ChangeEvenElement(int [,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            if(i%2==0 && j%2==0)    array[i,j]= array[i,j]*array[i,j];
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

int[,] array2D = CreateArray("Введите параметры создаваемого массива: ");

ChangeEvenElement(array2D);
FillArray(array2D);
Print2DArray(array2D);
Console.WriteLine();
ChangeEvenElement(array2D);
Print2DArray(array2D);


