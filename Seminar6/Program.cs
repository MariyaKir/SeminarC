// Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

void ReverseArray2(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);
WriteArray(myArray);
ReverseArray2(myArray);
WriteArray(myArray);
*/

// Task 1. Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.
/*
bool Triangl(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.Write("input the first line: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second line: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input athe third line: ");
int c = Convert.ToInt32(Console.ReadLine());

if (Triangl(a,b,c)) Console.WriteLine("Yes");
else Console.WriteLine("No");
*/
// Task 2. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два чиса Фибоначчи: 0 и 1. (Создать массив из чисел Фибоначчи)
/*
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int[] Fibonacci(int n)
{
    int[] fibArray = new int[n];
    fibArray[0] = 0;
    fibArray[1] = 1;
    for (int i = 2; i < fibArray.Length; i++)
    {
        fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
    }
    return fibArray;
}

Console.Write("input the last elem of fibonacci: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = Fibonacci(n);
WriteArray(myArray);
*/
// Task 3. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
int[] CopyArray(int size, int[] first_array)
{
    int[] second_array = new int[size];
    for(int i = 0;i < size; i++)
    {
        second_array[i] = first_array[i];
    }
    return second_array;
}

Console.Write("input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);
WriteArray(myArray);
int[] CopyMyArray = CopyArray(m, myArray);
WriteArray(CopyMyArray);
myArray[0] = 0;   // проверка с заменой первого элемента
WriteArray(myArray);
WriteArray(CopyMyArray);
*/