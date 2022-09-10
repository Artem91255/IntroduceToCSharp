//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateArray()
{
    Console.WriteLine("Создаю двумерный массив...");

    int rows = new Random().Next(1, 5);

    int columns = new Random().Next(1, 5);
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

double[] Average(int[,] array)
{
    double[] averageResult = new double[array.GetLength(1)];


    for(int i = 0; i<array.GetLength(1); i++)
    {
        double count=0;
        for(int j=0; j<array.GetLength(0); j++)
        {
            count = count+ array[j,i];
        }
        count =count/ array.GetLength(0);
        
        averageResult[i]= Math.Round(count,1);
    }
    return averageResult;
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

void PrintAverage(double[] arrayOfAverage)
{
    Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
    Console.WriteLine("{0}", string.Join("; ", arrayOfAverage));
}


int[,] array2D = CreateArray();
FillArray(array2D);
Print2DArray(array2D);
double[] result = Average(array2D);
PrintAverage(result);

