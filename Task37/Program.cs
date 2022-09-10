// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй
// и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] array4 = new int[6];
int[] array5 = new int[array4.Length / 2];

for (int i = 0; i < array4.Length; i++)
{
    int number = new Random().Next(0, 100);
    array4[i] = number;
    Console.Write(array4[i] + ", ");
}

//int multiply = 1;

for (int i = 0, j = array4.Length - 1; i < array4.Length / 2; i++, j--)
{
    array5[i] = array4[i] * array4[j];

}
Console.WriteLine("[{0}]", string.Join(", ", array5));