//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int[] Read(string line)
    {
        Console.Write(line);
        int M = int.Parse(Console.ReadLine());
        int[] array = new int[M];
        for(int i = 0; i<array.Length;i++)
        {
            Console.Write("Введите число № "+ (i+1) + " : ");
            int num = int.Parse(Console.ReadLine());
            array[i]=num;
        }


        return array;
    }

int Calculate(int[] array)
{
    int count=0;
    for(int i = 0; i<array.Length;i++)
        {
            if(array[i]>0)  count++;
        }
        return count;
}

void Print(int countOfNumbers)
{
    Console.WriteLine("Количество чисел больше 0: " + countOfNumbers);
}

int[] array = Read("Какое количество чисел будет введено: ");
int res =Calculate(array);
Print(res);