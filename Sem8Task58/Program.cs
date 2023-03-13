//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
// Генерируем перемножаемые массивы
int lengthArr1 = ReadData("Введите количество строк и столбцов для первого двумерного массива: ");
int lengthArr2 = ReadData("Введите количество строк и столбцов для второго двумерного массива: ");
int[,] arr1 = Gen2DArrRandomInt(lengthArr1, lengthArr1, 0, 100); // Генерируем первый массив числами от 0 до 100
int[,] arr2 = Gen2DArrRandomInt(lengthArr2, lengthArr2, 0, 100);// Генерируем второй массив числами от 0 до 100
// Метод для перемножения двумерных массивов 
int[,] ArrayMultiplication(int[,] arr1, int[,] arr2)
{
    int row1 = arr1.GetLength(0);
    int colum1 = arr1.GetLength(1);
    int row2 = arr2.GetLength(0);
    int colum2 = arr2.GetLength(1);
    // Для перемножения массивов необходимо создать третий,результирующий массив такой же размерности
    int[,] result = new int[row1, colum2];
// Перемножаем матрицы
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < colum2; j++)
        {
            int sum = 0;
            for (int k = 0; k < colum1; k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}
// Проверка на возможность перемножения массивов
if (lengthArr1 != lengthArr2)
{
    Console.WriteLine("Данные двумерные массивы перемножить нельзя");
    
}
else
{
    Console.WriteLine("Первый двумерный массив:");
    Print2DArr(arr1);
    Console.WriteLine(); // выведем пустую строку для разделения массивов
    Console.WriteLine("Второй двумерный массив:");
    Print2DArr(arr2);
    int[,] arr3 = ArrayMultiplication(arr1, arr2); //вызов метода для перемножения массивов
    Console.WriteLine(); // выведем пустую строку для разделения массивов
    Console.WriteLine("Результирующий массив:");
    Print2DArr(arr3);
}