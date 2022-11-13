/*/
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
/*/

Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

if (M<0) M=0;
if (N<0) N=0;

 if (M<=N) Console.WriteLine(GetSumNumb(M, N));
 else Console.WriteLine(GetSumNumb(N, M));

int GetSumNumb(int M, int N)
{
    if (M == N) return N;
    else return M + GetSumNumb(M + 1, N);
}


