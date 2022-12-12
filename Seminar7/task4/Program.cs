// Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


using static Common.Helper;

int[,] array = CreateRandom2DArray(5,5);

int sum = GetNeededSum(array);

Print2DArray(array);
Console.WriteLine();
Console.WriteLine(sum);

int GetNeededSum(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
               sum = sum + array[i,j];
            }
        }
    }
    return sum;
}