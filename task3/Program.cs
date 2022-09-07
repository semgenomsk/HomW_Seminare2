// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели Упырь: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >=1 && number <=7)
{
    if (number ==6 || number ==7)
    {
        System.Console.WriteLine("Поздравлю вас Упырь! отдыхай");
    }
    else
    {
        System.Console.WriteLine("Иди работай Упырь!");
    }
}
else
{
    System.Console.WriteLine("Номер недели введен некорректно!");
}