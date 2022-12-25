//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write ("Введите цифру, обозначающую день недели: ");
int numberA = int.Parse(Console.ReadLine()!);

if (numberA > 1 && numberA <= 5)
{
  Console.WriteLine($"Рабочий день");
}

else
{
  Console.WriteLine($"Выходной");
}
