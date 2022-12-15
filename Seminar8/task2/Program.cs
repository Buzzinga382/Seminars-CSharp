// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

using static Common.Helper;




int m = InputIntNumber("Number of rows:");
int n = InputIntNumber("Number of columns:");

int[,] userArray = CreateRandom2DArray(m, n);


int[,] turned2DArray = Turned2DArray(userArray);

Print2DArray(userArray);
Console.WriteLine();
Print2DArray(turned2DArray);



int[,] Turned2DArray(int[,] array)
{
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        int[,] turnedArray = new int[columns, rows];

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                turnedArray[i, j] = array[j, i];
            }
        }
    
    return turnedArray;
}

