﻿// Задача 3 (Нужно вывести день недели по введенному числу)

Console.WriteLine("Enter number");

int number = int.Parse(Console.ReadLine());

if (number < 1 | number > 7)
{
    Console.WriteLine("Error");
}

if (number == 1)
{
    Console.WriteLine("Monday");
}
if (number == 2)
{
    Console.WriteLine("Tuesday");
}
if (number == 3)
{
    Console.WriteLine("Wendsday");
}
if (number == 4)
{
    Console.WriteLine("Thursday");
}
if (number == 5)
{
    Console.WriteLine("Friday");
}
if (number == 6)
{
    Console.WriteLine("Saturday");
}
if (number == 7)
{
    Console.WriteLine("Sunday");
}