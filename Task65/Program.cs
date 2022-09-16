//Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int NumbersToN(int number1, int number2)
{
    
    if(number1>number2) return number2;
    
    else
    {
        Console.Write(number1+ ", ");
        number1++;
    
    }
    
    return NumbersToN(number1++, number2);

}

Console.WriteLine("Enter numStart: ");
int numStart = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter numFinish: ");
int numFinish = Convert.ToInt32(Console.ReadLine());

NumbersToN(numStart,numFinish);