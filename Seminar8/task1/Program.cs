// Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.

using static Common.Helper;


int[,] userArray = CreateRandom2DArray(5,7);

Print2DArray(userArray);
Console.WriteLine();

int[,] resultArray = ChangeFirstAndLastArrayRow(userArray);

Print2DArray(resultArray);




int[,] ChangeFirstAndLastArrayRow(int[,] array)
{
    int[,] newArray = Copy2DArray(array);

    for(int i = 0; i < array.GetLength(1); i++)
    {
        newArray[0,i] = array[array.GetLength(0) - 1, i];
        newArray[array.GetLength(0) - 1, i] = array[0,i];
    }
    return newArray;
}


int[,] Copy2DArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            result[i,j] = array[i,j];
        }
    }
    return result;
}