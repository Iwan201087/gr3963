//Задача 50. 
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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
// метод вывода двумерного массива  на экран с разукрашиванием элемента 
void Print2DArr(int [,] arr)
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
// метод для поиска элемента в массиве
bool FindOutputElem (int[,] arr, int row, int colum)
{
    if (arr.GetLength(0)>row&&arr.GetLength(1)>colum)
    {
        return true;
    }
    else
    {
        return false;
    }
}
int countRow = ReadData("Введите количество строк для двумерного массива: ");
int countColum = ReadData("Введите количество столбцов для двумерного массива: ");
int minMean = ReadData("Введите минимальное значение для элементов массива: ");
int maxMean = ReadData("Введите максимальное значение для элементов массива: ");
int indexRow = ReadData("Введите номер строки для поиска элемента: ");
int indexСolum = ReadData("Введите номер столбца для поиска элемента: ");
int [,] testArray=Gen2DArrRandomInt(countRow, countColum, minMean, maxMean);
Print2DArr(testArray);
if (FindOutputElem(testArray,indexRow,indexСolum))
{
     Console.WriteLine ( testArray[indexRow,indexСolum])
;
}
else
{
    Console.WriteLine ("Такого элемента в массиве нет");
}
