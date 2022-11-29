/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


*/

Console.Write("Введите число от которого нужно вывести числа: ");
int n = Convert.ToInt32(Console.ReadLine()!);
Console.Write($"Все натуральные числа от N до 1: ");
Rec(n);

void Rec(int n)
{
    Console.Write(n);

    if (n > 1)
    {
        Console.Write(", ");
        Rec(n - 1);
        return;
    }
    Console.WriteLine();
    return;
}

