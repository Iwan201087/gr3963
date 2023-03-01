// Задача № 34. Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Метод, для генерации исходного массива
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

//Метод, выводящий на печать сгенерированный исходный массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Метод для печати результатов вычеслений
void PrintData (string res)
{
    Console.WriteLine(res);
}
// Метод для вычесления количества четных элементов в массиве
int ContEvenElem(int[] inputArray)
{
    int res=0;
    int i=0;
    while (i<inputArray.Length) // Условие выхода из цикла
    {
        if (inputArray [i]%2==0)  // проверка на четность элементов масива
        {
            res++;  //накопление результата подсчета
        }
        i++; // изменение инкримента
    }
    return res; // возврат результатта, так как метод не void
}
int [] testArray = GenArray(100,100,999); // генерация массива, с которым будем работать, вввод параметров массива
Print1DArr(testArray); //Вывод массива в консоль
int res = ContEvenElem(testArray); // переменной res, присваиваем результат выполнения метода CountEvenElem
PrintData ("Четных элементов в исходном массиве:  " +res.ToString()); //Вывод результата подсчета количества четных элементов
