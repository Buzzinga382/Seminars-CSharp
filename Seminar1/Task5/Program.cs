// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Enter 3-digit number");

int number = int.Parse(Console.ReadLine());

// Первое решение

//int lastNum = number % 10;

//Console.WriteLine(lastNum);

int lastNum = number / 10;

lastNum = lastNum * 10;

lastNum = number - lastNum;

Console.WriteLine(lastNum);