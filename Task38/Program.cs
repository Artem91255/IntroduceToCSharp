/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/

Console.Clear();


int[] arrayOfNumbers = new int[8];
for(int i=0; i<arrayOfNumbers.Length; i++)
{
    int number = new Random().Next();
    arrayOfNumbers[i] = number;
}
Console.WriteLine("[{0}]", string.Join(",", arrayOfNumbers));
Console.WriteLine(Diff(arrayOfNumbers));

int Diff(int[] array)
{
    int max = array[0];
    for(int i = 0; i<array.Length; i++)
    {
        if (array[i]>max)  max = array[i];
    }
    int min = array[0];
    for(int i = 0; i<array.Length; i++)
    {
        if (array[i]<min)  min = array[i];
    }

    int difference = max-min;
    return difference;
}
