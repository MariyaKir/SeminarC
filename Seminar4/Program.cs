// Task 1. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
/*
int Sum(int a)
{
    int result = 0;
    for(int i = 1; i <= a; i++)
        result +=i;
    return result;
}
Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(number));
*/
// Task 2. Напишите программу, которая принимает на вход число и выдает колличество цифр в числе.
/*
int CountNum(int n)
{
    int count = 1;
    for(; 10 <= n; count ++)
        n = n/10;
    return count;
}
Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CountNum(number));
*/
// Task 3. Напишите программу, которая принимает на вход число N и выдает произведение нечетных чисел от 1 до N.
/*
int Prov(int a)
{
    int result = 1;
    for(int i = 1; i <= a; i = i + 2)
        result *=i;
    return result;
}
Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Prov(number));
*/

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);
*/