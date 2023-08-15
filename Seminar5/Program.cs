// Task 1. Задайте массив из m элементов, заполненный случайными числами из промежутка [a,b].
// Найдите сумму отрицательных элементов массива.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}
void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOfNegatives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sum += array[i];

    return sum;
}
Console.Write("input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);
WriteArray(myArray);
Console.WriteLine(SumOfNegatives(myArray));
*/
// Task 2. Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}
void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] Replace(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = array[i] * (-1);
    return array;
}

Console.Write("input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);
WriteArray(myArray);
WriteArray(Replace(myArray));
*/
// Task 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}
void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
bool Find(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(number == array[i])
            return true;
    }    
    return false;
    
}
Console.Write("input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(m, a, b);
WriteArray(myArray);
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool res = Find(myArray, number);
Console.WriteLine(res);
*/
// Task 4. Задайте одномерный массив из m чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int[] array = new int[size];

for(int i = 0; i < size; i++)
array[i] = new Random().Next(minValue, maxValue + 1);
return array;
}

void WriteArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
Console.Write(array[i] + " ");
Console.WriteLine();
}

int quantity (int[] array, int min_num, int max_num)
{
int count = 0;
for(int i = 0; i < array.Length; i++)
if (array[i] > min_num && array[i] < max_num) count++;
return count;
}

Console.Write("Enter a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, minValue, maxValue);
WriteArray(myArray);

Console.Write("Enter the Left border: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Right border: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(quantity(myArray, a, b));
*/