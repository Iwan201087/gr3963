//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
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
//Рекурсивный метод нахождения функции Аккермана
int FunctAckermannRec(int m, int n)
{
    if (m == 0)  //точка остановки рекурсии 
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)//точка остановки рекурсии 
    {
        return FunctAckermannRec(m - 1, 1);//изменение при вызове функции
    }
    else
    {
        return FunctAckermannRec(m - 1, FunctAckermannRec(m, n - 1));//изменение при вызове функции
    }
}
int num1 = ReadData("Введите первое неотрицательное число m: ");
int num2 = ReadData("Введите второе неотрицательное число n: ");

if (num1 < 0 || num2 < 0) PrintData("одно или оба ввёденых Вами чисела -  отрицательны");// проверка на сходимость функции
else PrintData($"A({num1},{num2}) = {FunctAckermannRec(num1, num2)}");