// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

int[,,] CreateArray()
{
    Console.WriteLine("Задаю техмерный массив:");

    int rows = 2;

    int columns = 2;
    int lines = 2;
    int[,,] array = new int[rows, columns, lines];

    return array;
}

int[] ElementsOf3DArray(int[,,] array3D)
{
    int value = array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2);
    int[] array1D = new int[value];
    for (int i = 0; i < array1D.Length; i++)
    {
        int j = new Random().Next(10, 99);
        while (true)
        {
            if (array1D.Contains(j)) j = new Random().Next(10, 99);
            else break;

        }
        array1D[i] = j;
    }
    return array1D;
}



void FillArray(int[,,] array3, int[] array1)
{
        int a = array1.Length-1;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    array3[i, j, k] = array1[a];
                    a--;
                }
            }
        }
    
}


void Print3DArray(int[,,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] +"("+i+","+j+","+k+")" +" ");
            }
            Console.WriteLine();
        }
       
    }
}

void Print1DArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
}

int[,,] array3d = CreateArray();
int[] array1d = ElementsOf3DArray(array3d);
FillArray(array3d, array1d);

Print3DArray(array3d);
