/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

Console.Clear();

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
sheet(x);

void sheet(int number)
{
double[] array = new double[number];
for(int i = 1; i<=number; i++)
{
   array[i-1] = Math.Pow(i,3);
   Console.Write(array[i-1] + " ");
}
}


