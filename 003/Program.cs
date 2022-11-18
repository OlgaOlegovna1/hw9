/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.WriteLine("Введите число M ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N ");
int n = int.Parse(Console.ReadLine());

int Ackermann(int n, int m)
{
    
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Ackermann(n - 1, 1);
    else
      return Ackermann(n - 1, Ackermann(n, m - 1));
}

Console.WriteLine(Ackermann(n, m));