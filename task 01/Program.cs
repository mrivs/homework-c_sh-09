/*/Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*/

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
if(N>0) Console.WriteLine(RecGetNumbers(N));
else Console.WriteLine("неверное число");

string RecGetNumbers(int N)
{
    if (N == 1) return $"{N}";
    else return $"{N}, " + RecGetNumbers(N - 1);
}

