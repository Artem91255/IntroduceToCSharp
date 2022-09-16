//Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


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
string Version2(int number2)
{
if (number2 == 1) {
            return "1";
        }
        // Шаг рекурсии / рекурсивное условие
        return Version2(number2 - 1) + ", " +  number2;
    }

Console.WriteLine("Enter N: ");
int numStart = 1;
int numFinish = Convert.ToInt32(Console.ReadLine());

NumbersToN(numStart,numFinish);
Console.WriteLine(" ");
Console.WriteLine(Version2(numFinish));

