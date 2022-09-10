// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//

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
int FindSummOfElementsInMainDiagonal(int[,] array)
{
    int count=0;
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            if(i==j)    count += array[i,j];
        }
    }
    return count;
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
void PrintElement(int number)
{
    Console.WriteLine(number);
}
int FindSummOfElementsUnderMainDiagonal(int[,] array)
{
    int count=0;
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            if(i> j)    count += array[i,j];
        }
    }
    return count;
}


int[,] array2D = CreateArray("Введите параметры создаваемого массива: ");
FillArray(array2D);
Print2DArray(array2D);
int result = FindSummOfElementsInMainDiagonal(array2D);
PrintElement(result);
int result2 = FindSummOfElementsUnderMainDiagonal(array2D);
PrintElement(result2);