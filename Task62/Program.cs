// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

int[,] FillArray(int number)
{
    int[,] array = new int[number, number];

    int iBeg = 0;
    int iEnd = number;
    int kBeg = 0;
    int kEnd = number;
    int amount = number * number;
    int value = 1;

    while (value < amount)
    {
        for (int i = kBeg; i < kEnd; i++) array[iBeg, i] = value++;
        for (int i = iBeg + 1; i < iEnd; i++) array[i, iEnd - 1] = value++;
        for (int i = kEnd - 2; i >= iBeg; i--) array[kEnd - 1, i] = value++;
        for (int i = iEnd - 2; i > kBeg; i--) array[i, iBeg] = value++;
        for (int i = iBeg + 1; i < 3; i++) array[iBeg + 1, i] = value++;
        for (int i = kEnd - 2; i > 0; i--) array[kEnd - 2, i] = value++;
    }

    return array;

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
Print2DArray(FillArray(4));