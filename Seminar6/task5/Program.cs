// Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.





double[] userArray = new double[]{1, 2, 5, 7, 9, 3};

double[] result = ArrayCopy(userArray);

PrintArray(userArray);
PrintArray(result);







double[] ArrayCopy(double[] array)
{
    double[] arrayCopy = new double[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}



void PrintArray(double[] array)
{
    string message = string.Join(" ", array);
    Console.WriteLine($"{message}");
}