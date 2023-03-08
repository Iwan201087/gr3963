//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Метод для получения данных от пользователя
int ReadInputInt(string mess)
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
// метод для вывода двумерного массива целых чисел на экран с раскрашиванием элементов 
void Print2DArr(int[,] arr)
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
//Метод для нахождения среднего арифметического элементов в каждом столбце 
double[] AveregeElemInColum(int[,] arr)// берем тип dooble, так как среднее арифметическое в столбце может быть не целым числом
{
    double[] res = new double[arr.GetLength(1)];
    
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            res[j] = res[j] + arr[i, j];// сумма элементов в столбце
        }
         res[j] = Math.Round(res[j]/ arr.GetLength(0),2);// значение среднего арифметического в столбце (если число вещественное, то выводить после запятой два знака) 
    }

    return res;
}

//Метод для печати одномерного массива (строки) с результатами вычесления среднего арифметического
void Print1DArrLine(double[] arr)// тип dooble
{

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]};\t"); //печатаем с табуляцией, для разделения значений между собой
    }
    Console.Write($"{arr[arr.Length - 1]}.");
}

int countRow = ReadInputInt("Введите количество строк для двумерного массива: ");
int countColum = ReadInputInt("Введите количество столбцов для двумерного массива: ");
int minMean = ReadInputInt("Введите минимальное значение для элементов массива: ");
int maxMean = ReadInputInt("Введите максимальное значение для элементов массива: ");
int[,] testArray = Gen2DArrRandomInt(countRow, countColum, minMean, maxMean);
Print2DArr(testArray);
Console.WriteLine(); // выведем пустую строку для разделения сгенерированного массива и массива с результатами
Print1DArrLine(AveregeElemInColum(testArray));