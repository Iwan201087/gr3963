//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
int SumOddIndexElem(int[] inputArray)
{
    int sum=0; //Начальное значение суммы принимаем равное 0
    for (int i = 0; i < inputArray.Length; i=i+2) // Условие выхода из цикла, i меняем с шагом +2, что бы всегда идти по нечетным позициям элементов
    {
        {
        sum=sum+inputArray[i];  //накопление результата подсчета
        }
        
    }
    return sum; // возврат результатта, так как метод не void
}
int [] testArray = GenArray(10,1,10); // генерация массива, с которым будем работать, ввод параметров массива
Print1DArr(testArray); //Вывод массива в консоль
int res = SumOddIndexElem(testArray); // переменной res, присваиваем результат выполнения метода SumOddIndexElem
PrintData ("Сумма элементов стоящих на нечетных позициях в исходном массиве:  " +res.ToString()); //Вывод результата подсчета количества четных элементов
