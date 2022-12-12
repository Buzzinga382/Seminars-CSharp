// Задайте двумерный массив размером m x n,
// заполненный случайными числами

using static Common.Helper;

int[,] array = CreateRandom2DArray(3,4);

Print2DArray(array);

(int, int) coordinates = GetSomething();

Console.WriteLine(coordinates.Item1);
Console.WriteLine(coordinates.Item2);


// Кортеж (в первые скобки пишем через запятую любые типы данных):

(int, int) GetSomething()
{
    int a = 5;
    int b = 6;
    return (a, b);
}