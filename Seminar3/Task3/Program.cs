/*
Задача 21: Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 2D пространстве.
 
A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
*/

int InputInt()
{
    Console.WriteLine("Введите целое число");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);

    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введите корректное значение");
        return -1;
    }
}

int ax = InputInt();
int ay = InputInt();
int bx = InputInt();
int by = InputInt();

double GetDistanceBetweenTwoPoints(int ax, int ay, int bx, int by)
{
    double ab = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
    return ab;
}

double result = GetDistanceBetweenTwoPoints(ax, ay, bx, by);

Console.WriteLine(result);