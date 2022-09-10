/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях*/

Console.Clear();


int[] arrayOfNumbers = new int[8];
for(int i=0; i<arrayOfNumbers.Length; i++)
{
    int number = new Random().Next();
    arrayOfNumbers[i] = number;
}
Console.WriteLine("[{0}]", string.Join(",", arrayOfNumbers));
Console.WriteLine(SumOfOddNumber(arrayOfNumbers));



String SumOfOddNumber(int[] array)
{
    int count=0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i]%2!=0)
        {
            count=count + array[i];
        }
    }
    return "Сумма элементов, стоящих на нечётных позициях: "+count;
}

