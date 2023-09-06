// Task 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
string PrintNumber(int num, string res)
{
    if(num == 1)
    {
        res = '1' + " " + res;
        return res;
    }
    else
    {
        res = num + " " + res;
        return PrintNumber(num - 1, res); 
    }
        
}

string result = "";
Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
result = PrintNumber(number, result);
Console.WriteLine(result);
*/
// Task 2. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M и N.
/*
string PrintNum(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNum(start + 1, end));
}
Console.WriteLine(PrintNum(1, 8));
*/

// Task 3. Напишиет программу, которая на вход принимает два числа А и В, и возводит число А в целую степень В с помощью рекурсиию
/*
int PowerAB(int a, int b)
{
    if (b == 0) return 1;
    else return a * PowerAB(a, b - 1);
}
Console.WriteLine(PowerAB(5, 3));
*/
// Task 4. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumDigits(int number)
{
    if(number == 0) return 0;
    else return number % 10 + SumDigits(number/10);
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigits(number));
*/