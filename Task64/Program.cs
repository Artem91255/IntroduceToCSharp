//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string allNumbersRecursion(int firstNumber, int secondNumber)
{
    
    if(firstNumber==secondNumber) return Convert.ToString(firstNumber);

    if(firstNumber<secondNumber) return allNumbersRecursion(firstNumber, secondNumber-1) + " " + secondNumber;

    else return allNumbersRecursion(firstNumber, secondNumber+1) + " " + secondNumber;
}

Console.WriteLine("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(allNumbersRecursion(firstNum,secondNum));