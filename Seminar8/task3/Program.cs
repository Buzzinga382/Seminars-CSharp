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

int[,] userArray = CreateRandom2DArray(m, n);

Print2DArray(userArray);
Console.WriteLine();

int[,] dict = Dict1DArray(userArray);
Print2DArray(dict);
Console.WriteLine();

int[,] result = FrequencyDictionary(dict);
Print2DArray(result);
Console.WriteLine();

PrintDictionary(result);






int[,] Dict1DArray(int[,] array)
{
    int[,] dictArray = new int[2, array.Length];
    int temp = 0;
    int k = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = array[i, j]; 
            dictArray[0,k] = temp;
            k++;
        }
    }
    return dictArray;
}


int[,] FrequencyDictionary(int[,] array)
{
    int count = 0;
    int j = 0;
    int temp = 0;

    while(j < array.GetLength(1))
    {
    temp = array[0,j];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        if(temp == array[0, i])
        {
            count++;
            array[1,j] = count;
        }
    }
    count = 0;
    j++;
    }
    return array;
}

void PrintDictionary(int[,] dictArray)
{
    int tmp = 0;
    Console.WriteLine($"Number {dictArray[0,0]} repeated {dictArray[1,0]} times");
    int j = 1;

     while(j < dictArray.GetLength(1))
     {
        tmp = dictArray[0,j];
     for (int i = 1; i < dictArray.GetLength(1); i++)
     {
        if(tmp != dictArray[0,i])
        {
            Console.WriteLine($"Number {dictArray[0,i]} repeated {dictArray[1,i]} times");
        }
     }
     j++;
     }
}