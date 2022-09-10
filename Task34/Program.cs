/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

Console.Clear();


int[] arrayOfNumbers = new int[8];
for(int i=0; i<arrayOfNumbers.Length; i++)
{
    int number = new Random().Next(100,1000);
    arrayOfNumbers[i] = number;
}
Console.WriteLine("[{0}]", string.Join(",", arrayOfNumbers));
Console.WriteLine(CountOfEvenNumber(arrayOfNumbers));



String CountOfEvenNumber(int[] array)
{
    int count=0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i]%2==0)
        {
            count++;
        }
    }
    return "Количество четных элементов в массиве: "+count;
}

