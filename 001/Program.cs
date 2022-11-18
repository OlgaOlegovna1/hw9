/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "4, 2"
N = 8 -> "8, 6, 4, 2,"*/

Console.WriteLine("Введите число  ");
int n = int.Parse(Console.ReadLine());

EvenNumber(n);
Console.WriteLine("проверка");
Console.WriteLine(EvenNumberRec(n));

void EvenNumber(int n)
{
    int number = 1;
    while (n > number)
    {
        number++;
        if ((number % 2) == 0)
        {
            Console.Write(number + ", ");
        }
    }
}

int EvenNumberRec(int n)  //рекурсия
{
    
    if (1 > n) return 0;
    if ((n % 2) != 0) n = n-1;
    Console.Write(n + ", ");

   return EvenNumberRec(n - 2);

}


