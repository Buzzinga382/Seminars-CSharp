namespace Common;

public static class Helper
{
    public static int[] GenerateArray(int min, int max, int length)
    {
        Random random = new Random();
        int[] array = new int[length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(min, max + 1);
        }
        return array;
    }

    public static void PrintArray(int[] array)
    {
        string message = string.Join(", ", array);
        Console.WriteLine($"[{message}]");
    }

    public static int[] ReverseArray(int[] array)
    {
        int[] reverseArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            reverseArray[i] = array[array.Length - 1 - i];
        }
        return reverseArray;
    }

    public static void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
    {
        Random random = new Random();
        int[,] array = new int[countOfRows, countOfColumns];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(-10, 11);
            }
        }
        return array;
    }
}
