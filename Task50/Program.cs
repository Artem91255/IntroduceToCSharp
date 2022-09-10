// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateArray()
{
    Console.WriteLine("Создаю двумерный массив...");

    int rows = new Random().Next(1, 10);

    int columns = new Random().Next(1, 10);
    int[,] array = new int[rows, columns];

    return array;
}
int ElementOfArray(string text)
{
    Console.Write(text);

    int rows = Convert.ToInt32(Console.ReadLine());
    return rows;
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

bool searchElement(int [,] array, int element)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == element)      count++;
        }
       
    }
     return count>0;


}

void PrintResult(bool choice)
{
     if(choice)      Console.WriteLine("Указанный элемент присутствует в массиве");
     else   Console.WriteLine("Указанный элемент в массиве отсутствует");
    
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


int[,] array2D = CreateArray();
FillArray(array2D);
Print2DArray(array2D);
int key = ElementOfArray("Введите элемент, который необхоидмо найти в массиве: ");
bool result = searchElement(array2D, key);
PrintResult(result);