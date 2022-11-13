﻿/*/
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
/*/
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());

if (n >= 0 && m >= 0) Console.WriteLine(GetAckerman(m, n));
else Console.WriteLine("числа m и n должны быть неотрицательными");

int GetAckerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return GetAckerman(m - 1, 1);
    else if (m > 0 && n > 0) return GetAckerman(m - 1, GetAckerman(m, n - 1));
    else return -1;
}