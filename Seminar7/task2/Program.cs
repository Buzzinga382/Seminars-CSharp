// Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aₙₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4. 
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


using static Common.Helper;

int[,] array = GetArray(5,7);

Print2DArray(array);



int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
        }
    }
    return array;
}