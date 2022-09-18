//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SummAllNumbersRecursion(int firstNumber, int secondNumber)
{
    
    if(firstNumber>secondNumber) return 0;

    

        
      
        return  firstNumber+  SummAllNumbersRecursion(firstNumber+1, secondNumber);;
    
   
     
}

Console.WriteLine("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SummAllNumbersRecursion(firstNum,secondNum));