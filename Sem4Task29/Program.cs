//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Ввести с клавиатуры длину массива и диапазон значений элементов.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
//Метод для получения данных от пользователя
int ReadInput(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Метод для генерации массива случайными числами
int[] Gen1DArr(int len, int minVal, int maxVal)
{
    Random rnd = new Random();
    int[] arr = new int[len];

    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(minVal, maxVal + 1);
    }

    return arr;
}

//Метод для вывода массива на экран
void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},\t");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

//Вызов метода для получения данных от пользователя
int length = ReadInput("Введите длину массива: ");
int min = ReadInput("Введите минимальный элемент массива: ");
int max = ReadInput("Введите максимальный элемент массива: ");
if (min<max) Print1DArr(Gen1DArr(length, min, max));
else Print1DArr(Gen1DArr(length, max, min));