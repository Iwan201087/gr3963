//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

//Метод для ввода данных от пользователя
int ReadInput(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
//Метод для вывода данных
void WriteMess(string mess)
{
    Console.WriteLine(mess);
}
// Метод подсчета суммы цифр внутри числа
int Summ(int num)
{
    int res = 0;

    while (num > 0)
    {
        res += num % 10;
        num /= 10;
    }

    return res;
}

//Вызов метода для получения данных от пользователя
int num = ReadInput("Введите число: ");
//Вывод результата
WriteMess($"Сумма цифр в числе {num} = {Summ(num)}");
