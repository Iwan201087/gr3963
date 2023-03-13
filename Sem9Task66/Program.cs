//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//Метод для получения данных от пользователя
int ReadData(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
//Метод для вывода в консоль сообщения
void PrintData(string mess)
{
    Console.WriteLine(mess);
}
// Рекурсивный метод, который находит сумму натуральных элементов в промежутке от M до N
int SumNumRec(int M, int N)
{
    int sum = 0;//Инициализируем переменную sum

    if (M > N) return sum; // точка остановки рекурсии 
    else
    {   
        sum += M + SumNumRec(M + 1, N); //изменение при вызове функции
        return sum;
    }
}
int num1 = ReadData("Введите левую границу промежутка сумирования М: ");
int num2 = ReadData("Введите правую границу промежутка сумирования N: ");
PrintData($"Cумма натуральных элементов в промежутке от M до N = {SumNumRec(num1, num2)}");