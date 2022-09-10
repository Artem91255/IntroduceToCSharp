/*Задача 29. Напишите программу, которая задает массив из 8 элементов и выводит их на экран*/

Console.Clear();

int[] array = new int[8];
for(int i=0; i<array.Length; i++)
{
    int number = new Random().Next(1,1000);
    array[i] = number;
    Console.Write(array[i] + ", ");
    
}
//Второй вариант вывода массива на экран
Console.WriteLine("[{0}]", string.Join(",", array));
