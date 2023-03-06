//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Принимаем из консоли число
int ReadData(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
int[] InputArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadData ($"Введите  число");
    }
    return array;
}
//Метод, выводящий на печать полученный массив из введенных чисел
void Print1DArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}
//Метод, подсчитывающий количество положительных элементов введенных пользователем
int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i] > 0);
        {
            count++;
        }
    }
    return count;
}
int len=ReadData ("Введите количество вводимых элементов");
int [] array;
array = InputArray (len);
Print1DArray (array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");