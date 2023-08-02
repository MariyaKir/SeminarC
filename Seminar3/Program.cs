// Seminar 3.

//Theory
/*
Console.WriteLine(Math.Pow(5, 2));
Console.WriteLine(Math.Sqrt(24));
Console.WriteLine(Math.Round(Math.Sqrt(24), 2));
Console.WriteLine(Math.Round(4.125, 2));
*/
// Task 1. Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных  координат точек в этой четверти (x и y).
/*
void WriteRange(int quadrant)
{
    if(quadrant < 1 || quadrant > 4) Console.WriteLine("Uncorrect data!");
    else if (quadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if (quadrant == 2) Console.WriteLine("x < 0 and y > 0");
    else if (quadrant == 3) Console.WriteLine("x < 0 and y < 0");
    else Console.WriteLine("x < 0 and y > 0");
}

Console.Write("Input a number of quadrant: ");
int quad = Convert.ToInt32(Console.ReadLine());

WriteRange(quad);
*/
// Task 2. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X /= 0 и Y /= 0 и выдает номер четверти плоскости, в которой находится эта точка.
/*
int Quadrant(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quad = Quadrant(x, y);
if (quad == 0) Console.WriteLine("Uncorrected data");
else Console.Write("Quadrant number is: " + quad);
*/
// Task 3. Напишите программу, которая принимает на вход число (N) и выдает квадраты чисел от 1 до N.
/*
// 1 - 1
// 2 - 4
// 3 - 9
// 4 - 16

void WriteQuad(int number)
{
    int current = 1;
    while (current <= number)
    {
        Console.WriteLine($"{current} - {current * current}");
        current++;
    }
}
Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

WriteQuad(number);
*/
// Task 4. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double Distance(double x1, double y1, double x2, double y2)
{
    double deltaX = x2 - x1;
    double deltaY = y2 - y1;
    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
}
Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Distance(x1, y1, x2, y2));
*/