//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
            Console.ForegroundColor = col[new Random().Next(0,6)];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
//Метод сортировки пузырьком 
int [] BubbleSort (int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }                   
        }            
    }
    return arr;
}
//Метод сортировки пузырьком строки в двумерном массиве 
void Sort2DArr(int[,] arr)
{
    int [] row= new int[arr.GetLength(1)]; // вводим буферную переменную, длинной в строку, для реализации сортировки строки
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < row.Length; j++)
        {
           row[j] = arr[i,j];                     
        } 
        BubbleSort (row); // Вызов метода BubbleSort для сортировки одномерного масива row (строки)
        for (int j = 0; j < row.Length; j++)
        {
            arr [i,j] = row[j];
        }
    }
    
}
int countRow = ReadData("Введите количество строк для двумерного массива: ");
int countColum = ReadData("Введите количество столбцов для двумерного массива: ");
int minMean = ReadData("Введите минимальное значение для элементов массива: ");
int maxMean = ReadData("Введите максимальное значение для элементов массива: ");
Console.WriteLine("Исходный массив:");
int[,] testArray = Gen2DArrRandomInt(countRow, countColum, minMean, maxMean);
Print2DArr(testArray);
Console.WriteLine(); // выведем пустую строку для разделения сгенерированного массива и отсортированного массива 
Sort2DArr (testArray);
Console.WriteLine("Отсортированный массив:");
Print2DArr(testArray);

