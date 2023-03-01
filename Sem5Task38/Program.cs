// Задача № 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Метод, для генерации исходного массива вещественных чисел
double[] GenArray(int len, int minValue, int maxValue)
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1)+(new Random().NextDouble());
        arr[i]=Math.Round(arr[i],2);
    }
    return arr;
}
//Метод, выводящий на печать сгенерированный исходный массив вещественных чисел
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Метод для сортировки исходного массива
void Sort(double[] array)
{
    for (int i=0; i<array.Length;i++)
        for (int j=0;j<array.Length-i-1;j++)
        {
            if (array[j]>array[j+1])
            {
                double buf=array[j]; // обмен через буфферную переменную
                array[j]=array[j+1];
                array[j+1]=buf;
            }
        }
}
double [] testArray = GenArray(10,0,10); // генерация массива, с которым будем работать, вввод параметров массива
Print1DArr(testArray); //Вывод массива в консоль
Sort(testArray); // сортировка массива
Print1DArr(testArray); // вывод отсортированного массива
Console.WriteLine(testArray[testArray.Length-1]-testArray[0]); // вывод разницы между последним  и первым элементом массива, так как массив отсортирован это и будет разница между max  и min элементами
