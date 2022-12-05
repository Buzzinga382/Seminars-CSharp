/* Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

int[] array = GenerateArray(-10, 10, 6);

PrintArray(array);

int[] result = GetProductOfSimmetricElements(array);

PrintArray(result);










int[] GetProductOfSimmetricElements(int[] array)
{
    int newArrLenght = array.Length / 2;
    if (array.Length % 2 != 0)
    {
        newArrLenght = newArrLenght + 1;
    }

    int[] newArray = new int[newArrLenght];
    int i;

    for (i = 0; i < newArrLenght - 1; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 == 0)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    else
    {
        newArray[i] = array[i];
    }

    return newArray;
}



int[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    string message = string.Join(", ", array);
    Console.WriteLine($"[{message}]");
}