/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число А в натуральную степень В*/

Console.Clear();

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(func(a,b));

int func (int firstNumber, int secondNumber)
{
    int c=1;
    for(int i = 1; i<=secondNumber; i++)
    {
        c=c*firstNumber;
    }
    return c;
}