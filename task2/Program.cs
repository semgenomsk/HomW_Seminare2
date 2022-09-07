// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine());

if (Math.Abs(number) > 99)
{
    while (Math.Abs(number) > 999)
    {
        number=number/10;
    }
    long digit3=number % 10;
    System.Console.WriteLine(Math.Abs(digit3));
}
else
{
    System.Console.WriteLine("Третьей цифры! Упырь");
}