/*Задача 66: Задайте значения M и N.
 Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


Console.WriteLine("Введите число M ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N ");
int n = int.Parse(Console.ReadLine());

void SumElement(int N, int M)
{
    int sum = M;
    while (N > M)
    {
        sum = sum + N; 
        N--;
    }
    Console.Write(sum);
}
SumElement(n, m); 
Console.WriteLine();
Console.WriteLine("проверка");

int SumElementRec(int M, int N)  //рекурсия
{

    if (N < M) return 0;
    
    else return N + SumElementRec(M, N - 1);
    
}

Console.Write(SumElementRec(m, n));