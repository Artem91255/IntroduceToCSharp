//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// A(0,n) A=n+1
// A(m>0, n=0) A(m-1,1)
// A(m>0,n>0)  A(m-1, A(m,n-1))

int AkkermanRecursion(int m, int n)
{
if(m==0 && n>0) return n+1;
if((m>0) && (n==0)) return AkkermanRecursion(m-1,1);
else
return AkkermanRecursion(m-1, AkkermanRecursion(m,n-1));
}

Console.WriteLine("Введите первое число: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AkkermanRecursion(numM,numN));
