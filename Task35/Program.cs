// // // Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// // // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// // // [5, 18, 123, 6, 2] -> 1
// // // [1, 2, 3, 6, 2] -> 0
// // // [10, 11, 12, 13, 14] -> 5

int[] array3 = new int[123]; // Код заполнения массива
for(int i=0; i<array3.Length; i++)
{
int number = new Random().Next(0,100);
array3[i] = number;
Console.Write(array3[i] + ", ");
}

System.Console.WriteLine();

int count = 0; //Переменная счетчика

foreach(int a in array3) //Пробежались по элементам массива 
{
    
    if (a > 9 && a < 100) //проверили диапазон
    count ++;
}
System.Console.WriteLine(count);

Console.WriteLine("[{0}]", string.Join(", ", array3));