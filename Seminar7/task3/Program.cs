// Задайте двумерный массив. Найдите элементы,
// у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


using static Common.Helper;

int[,] array = CreateRandom2DArray(5, 5);

int[,] result = GetNeededArray(array);

Print2DArray(array);
Console.WriteLine();
Print2DArray(result);

int[,] GetNeededArray(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                newArray[i, j] = array[i, j] * array[i, j];
            }
            else
            {
                newArray[i, j] = array[i, j];
            }
        }
    }
    return newArray;
}