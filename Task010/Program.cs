// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.Clear ();

Console.Write ("Введите трехзначное число: ");
int numberA = int.Parse(Console.ReadLine()!);
int digitIndex = 1;

int digit  = numberA.ToString()[digitIndex] - '0';

Console.WriteLine ($"Вторая цифра этого числа {digit}");
