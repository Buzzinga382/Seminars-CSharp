/* Напишите программу, которая принимает на
вход три числа и проверяет, может ли существовать
треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. */


Console.WriteLine("Please enter 3 numbers:");

bool isParsed1 = int.TryParse(Console.ReadLine(), out int num1);

if (!isParsed1)
{
    Console.WriteLine("Incorrect input");
}

bool isParsed2 = int.TryParse(Console.ReadLine(), out int num2);

if (!isParsed2)
{
    Console.WriteLine("Incorrect input");
}

bool isParsed3 = int.TryParse(Console.ReadLine(), out int num3);

if (!isParsed3)
{
    Console.WriteLine("Incorrect input");
}

bool res = IsTriangle(num1, num2, num3);

Console.WriteLine(res);





bool IsTriangle(int num1, int num2, int num3)
{
    if (num1 < (num2 + num3) && num2 < (num1 + num3) && num3 < (num1 + num2))
    {
        return true;
    }
    else
    {
        return false;
    }
}