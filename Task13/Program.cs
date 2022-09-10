//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.WriteLine("Введите число");
String str = Console.ReadLine();
char[] array;
int temp = Convert.ToInt32(str);
int number;
if(temp<0)
{
    number = -1*temp;
}
else
{
    number = temp;
}

if(number<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    String s = Convert.ToString(number);
    array = s.ToCharArray(0,s.Length);
    Console.WriteLine("Третья цифра введенного числа это "+ array[2]);
    
}
