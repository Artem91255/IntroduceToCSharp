//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.WriteLine("Введите пятизначное число");

string number = Console.ReadLine();
Test(number);


    string Test(string str)
    {
    char[] charArray = number.ToCharArray();
  
   if (charArray[0] == charArray[4] || charArray[1] == charArray[3])
         Console.WriteLine("Введенное число является полиндромом");
    else
         Console.WriteLine("Введенное число не является полиндромом");
       
    return null; 
        }
    

