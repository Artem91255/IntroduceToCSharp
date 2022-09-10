// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да



int[] array2 = { 6, 7, 5, 9, 3, 1 };
System.Console.WriteLine("Введите искомое число:");
int x = Convert.ToInt32(Console.ReadLine());

if (array2.Contains(x))
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}

