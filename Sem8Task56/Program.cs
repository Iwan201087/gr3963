//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Метод для получения данных от пользователя
int ReadData(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
//Метод генерации массива случайными целыми числами 
int[,] Gen2DArrRandomInt(int row, int colum, int minMean, int maxMean)
{
    Random rnd = new Random();
    int[,] arr = new int[row, colum];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            arr[i, j] = rnd.Next(minMean, maxMean);
        }
    }
    return arr;
}
// метод для вывода двумерного массива целых чисел на экран с раскрашиванием элементов шестью цветами
void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Blue,ConsoleColor.Yellow,ConsoleColor.Green,
                                            ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 6)];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
// метод для нахождения минимального индекса строки
int FindMinIndex(int[] arr)
{
    int min = int.MaxValue;
    int minIndex = -1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            minIndex = i;
        }
    }

    return minIndex;
}
// метод для нахождения суммы элементов в строке и вывода номера строки с мин индексом
string FindSumElemInRow(int[,] arr)
{
    int[] sum = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum[i] += arr[i, j];
        }
    }

    int minIndex = FindMinIndex(sum);

    return $"Строка с наименьшей суммой элементов - {minIndex+1} "; // так как нумерация индексов идет с 0
}
int countRow = ReadData("Введите количество строк для двумерного массива: ");
int countColum = ReadData("Введите количество столбцов для двумерного массива: ");
int minMean = ReadData("Введите минимальное значение для элементов массива: ");
int maxMean = ReadData("Введите максимальное значение для элементов массива: ");
int[,] testArray = Gen2DArrRandomInt(countRow, countColum, minMean, maxMean);
Print2DArr(testArray);
Console.WriteLine(FindSumElemInRow(testArray));


