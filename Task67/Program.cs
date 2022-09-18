//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SummNum(int num)
{
    
    if(num<10) return num;

    else
    return num%10 + SummNum(num/10) ;
}



Console.WriteLine("Введите число: ");
int temp = 0;
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SummNum(num));

