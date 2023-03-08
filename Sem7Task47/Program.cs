//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//Метод для получения данных от пользователя
int ReadInputInt(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
//Метод генерации массива случайными числами типа double
double[,] Gen2DArrRandomDouble(int row, int colum, int minMean, int maxMean)
{
    Random rnd = new Random();
    double[,] arr = new double[row, colum];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            arr[i, j] = Math.Round(rnd.Next(minMean, maxMean) + rnd.NextDouble(), 2); // генерация вещественными числами от минума и максимума введенными пользователем с точностью до двух знаков после запятой
        }
    }
    return arr;
}
// метод вывода двумерного массива вещественных чисел на экран с раскрашиванием элементов 
void Print2DArr(double[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Blue,ConsoleColor.Yellow,ConsoleColor.Green,
                                            ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0,6)];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
int countRow = ReadInputInt("Введите количество строк исходного двумерного массива: ");
int countColum = ReadInputInt("Введите количество столбцов исходного двумерного массива: ");
int minMean = ReadInputInt("Введите минимальное значение для вывода вещественных чисел: ");
int maxMean = ReadInputInt("Введите максималльное значение для вывода вещественных чисел: ");
double[,] testArr = Gen2DArrRandomDouble(countRow, countColum, minMean, maxMean);
Print2DArr(testArr);