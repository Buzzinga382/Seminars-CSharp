// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз 
// встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза


using static Common.Helper;


int m = InputIntNumber("Number of rows:");
int n = InputIntNumber("Number of columns:");

int[,] userArray = CreateRandom2DArray(m,n);

Print2DArray(userArray);
Console.WriteLine();





int[,] FrequencyDictionary(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] dictionary = new int[array.Length, 2];

    int tempI = 0;
    int tempJ = 0;
    int count = 0;

    for(int i = tempI; i < columns; i++)
    {
        for(int j = tempJ; j < rows; j++)
        {
            if(array[i,j] == array[tempI, tempJ])
            {
                count++;
            }

        }
    }
}