// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// k1 * x + b1= k2 * x + b2 => k1 * x-k2 * x= -b1+b2 =>x=(-b1+b2)/k1-k2

double[] Read(string line)
    {
        double[] numbers = new double[4];
        Console.WriteLine(line);
        Console.Write("Введите число b1: ");
        double b1 = double.Parse(Console.ReadLine());
        numbers[0] = b1;
        Console.Write("Введите число b2: ");
        double b2 = double.Parse(Console.ReadLine());
        numbers[1]=b2;
        Console.Write("Введите число k1: ");
        double k1 = double.Parse(Console.ReadLine());
        numbers[2] = k1;
        Console.Write("Введите число k2: ");
        double k2 = double.Parse(Console.ReadLine());
        numbers[3] = k2;
        return numbers;
    }

double[] FindPoint(double[] array)
{
    
    double[] point = new double[2];
    double x = (-array[0]+array[2])/(array[1]-array[3]);
    double y=array[1] * x + array[0];
    point[0] = x;
    point[1]= y;
    return point;


}

void Print(double[] point, double x, double y)
{
     Console.WriteLine("Ответ:");
     Console.WriteLine("x = " + x);
     Console.WriteLine("y = " + y);
}

double[] arrayOfNumbers = Read("Введите данные для решения уравлений y = k1 * x + b1, y = k2 * x + b2.");
double[] points = FindPoint(arrayOfNumbers);
Print(points, points[0], points[1]);