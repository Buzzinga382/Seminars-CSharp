// Программа, которая принимает на вход Х и У, причём они не ноль,
// и выдаёт номер четверти плоскости, в которой находится эта точка

Console.WriteLine("Введите координату X");

bool isParsedX = int.TryParse(Console.ReadLine(), out int x);

Console.WriteLine("Введите координату Y");

bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

if(!isParsedX || !isParsedY || x == 0 || y == 0) // По идее отсюда можно удалить проверку равенства координат нулю, потому что мы потом проверили это в методе с помощью -1
{
    Console.WriteLine("Неверные координаты");
    return;
} 

int quarterNumber = GetQuarterNumberByCoordinates(x, y);

if(quarterNumber == -1)
{
    Console.WriteLine("Координаты равны нулю");
    return;
}

// возвращаемый_тип_данных НазваниеМетода()
// { 
//    тело метода
//    оператор return
// }

Console.WriteLine($"Номер четверти {quarterNumber}");

int GetQuarterNumberByCoordinates(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }

    if (x < 0 && y > 0)
    {
        return 2;
    }

    if(x < 0 && y < 0)
    {
        return 3;
    }
    
    if(x > 0 && y < 0)
    {
        return 4;
    }

    return -1;

}