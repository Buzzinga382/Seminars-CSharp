/*
 Решение в группах задач:
Задача 18: Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

Console.WriteLine("Введите номер четверти");

bool isParsed = int.TryParse(Console.ReadLine(), out int n);

if(!isParsed)
{
    Console.WriteLine("Неверный номер четверти");
    return;
} 

string coord = GetCoordinates(n);

if(coord == "false")
{
    Console.WriteLine("Неверный номер четверти");
    return;
}

Console.WriteLine(coord);

string GetCoordinates (int n)
{
    if(n == 1)
    {
        return("x > 0 && y > 0");
    }

    if(n == 2)
    {
        return("x < 0 && y > 0");
    }

    if(n == 3)
    {
        return("x < 0 && y < 0");
    }

    if(n == 4)
    {
        return("x > 0 && y < 0");
    }

    return "false";
}