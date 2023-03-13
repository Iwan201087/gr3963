// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int ReadData(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Генерируем массив случайными неповторяющимися числами
int[,,] Gen3DArrRandomNonRepeatingElem(int row, int colum, int page, int minMean, int maxMean)
{
    Random rnd = new Random();
    int[,,] arr3D = new int[row, colum, page];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            for (int k = 0; k < page; k++)
            {
                while (true)
                {
                    int elem = rnd.Next(minMean, maxMean);
                    if (CheckElementIn3DArray(arr3D, elem) == false)
                    {
                        arr3D[i, j, k] = elem;
                        break;// прерываем цикл
                    }
                }
            }
        }  
    }

    return arr3D;
}
// выводим двумерный массив на экран 
void Print3DArr(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                Console.Write($"{arr3D[i, j, k]} ({i}, {j}, {k})\t");//печать каждого элемента с указанием индекса
                Console.Write(arr3D[i,j,k] +" (" + i + ", " + j +", " + k +")\t");
                Console.Write("{0} ({1}, {2}, {3})\t", arr3D[i,j,k], i, j, k);
            }
            Console.WriteLine();
        }
    }
}
//Метод для проверки элемента в массиве на повторяемость
bool CheckElementIn3DArray(int[,,] arr3D, int elem)
{
    // перебираем элементы массива
for (int i = 0; i < arr3D.GetLength(0); i++)
{
    for (int j = 0; j < arr3D.GetLength(1); j++)
    {
        for (int k = 0; k < arr3D.GetLength(2); k++)
        {
            if (arr3D[i,j,k] == elem) // если элемент равен искомому числу
            {
                return true; // выходим из метода, так продолжать поиск бессмысленно
            }
        }
    }
}
return false;//число не было найдено
}

int countRow = ReadData("Введите количество строк для трехмерного массива: ");
int countColum = ReadData("Введите количество столбцов для трехмерного массива: ");
int countPage = ReadData("Введите количество страниц для трехмерного массива: ");
int minMean = ReadData("Введите минимальное значение для элементов массива: ");
int maxMean = ReadData("Введите максимальное значение для элементов массива: ");

int[,,] test3DArr = Gen3DArrRandomNonRepeatingElem(countRow, countColum, countPage, minMean, maxMean);

Console.WriteLine("3D массив с выводом индексов:");
Print3DArr(test3DArr);
