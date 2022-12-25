// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. 

Console.Clear ();

Console.Write ("Введите число: ");
int numberA = int.Parse(Console.ReadLine()!);
int digitIndex = 2;

if ( numberA > 100)
{
  int digit  = numberA.ToString()[digitIndex] - '0';
  Console.WriteLine ($"Третья цифра этого числа {digit}");
}
else 
{
  Console.WriteLine($"Третьей цифры нет");
}
