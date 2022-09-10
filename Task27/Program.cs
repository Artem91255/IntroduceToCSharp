/*Задача 27: Напишите программу, которая принимает на вход число и выдает сумму цифр в числе*/

Console.Clear();

Console.WriteLine("Введите число");
string num = Console.ReadLine();
Console.WriteLine("Сумма цифр введенного числа равна " + SumOfNumbers(num));


int SumOfNumbers(string number)
{
    //string to char
    int sum=0;
    char[] charArray = number.ToCharArray();

    //char to int
    int[] intArray = new int[charArray.Length];
    for(int i =0; i<charArray.Length; i++)
    {
        intArray[i]=charArray[i]-'0';
        sum=sum+intArray[i];
  
    }
    return sum;
}